using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using IslandLogin.Models;

namespace IslandLogin
{
    public partial class IslandLogin
    {

        /// <summary>
        /// Gets the base64 token.
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Gets the xsd auto generated model of the decoded token.
        /// </summary>
        public Response IslandSaml { get; }

        /// <summary>
        /// Gets the XmlDocument of the decoded token.
        /// </summary>
        public XmlDocument XmlDocument { get; }

        /// <summary>
        /// Gets all the info you really need that was extracted from the token.
        /// </summary>
        public Island Island { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IslandLogin"/> class.
        /// </summary>
        /// <param name="token">
        /// A Base64 encoded SAML2 string from island.is.
        /// </param>
        public IslandLogin(string token)
        {
            Token = token;

            string xmlString = Encoding.UTF8.GetString(Convert.FromBase64String(Token));

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);
            XmlDocument = xmlDocument;

            using (XmlTextReader reader = new XmlTextReader(new StringReader(xmlString)))
            {
                var serializer = new XmlSerializer(typeof(Response));
                IslandSaml = (Response)serializer.Deserialize(reader);
            }

            Island = new Island
            {
                Id = IslandSaml.ID,
                Audience = IslandSaml.Assertion.Conditions.AudienceRestriction.Audience,
                Destination = IslandSaml.Destination,
                NotBefore = IslandSaml.Assertion.Conditions.NotBefore,
                NotOnOrAfter = IslandSaml.Assertion.Conditions.NotOnOrAfter,
            };

            // much clean, such w0w.
            foreach (var item in IslandSaml.Assertion.AttributeStatement)
            {
                if (item.Name == "IPAddress") Island.IPAddress = item.AttributeValue;
                else if (item.Name == "Authentication") Island.Authentication = item.AttributeValue;
                else if (item.Name == "AuthID") Island.AuthId = item.AttributeValue;
                else if (item.Name == "Name") Island.Name = item.AttributeValue;
                else if (item.Name == "DestinationSSN") Island.ReceiverId = item.AttributeValue;
                else if (item.Name == "UserAgent") Island.UserAgent = item.AttributeValue;
                else if (item.Name == "UserSSN") Island.UserId = item.AttributeValue;
                else if (item.Name == "Mobile") Island.Mobile = item.AttributeValue;
            }
        }

        /// <summary>
        /// Determines whether the IslandLogin.Token property verifies.
        /// </summary>
        /// <returns>true if the IslandLogin.Token property verifies; otherwise, false.</returns>
        public bool Verify()
        {
            // Ensure dates are valid.
            if (Island.NotBefore > DateTime.Now || Island.NotOnOrAfter < DateTime.Now) return false;

            SignedXml signedXml = new SignedXml(XmlDocument);

            // Find the signature node.
            var node = XmlDocument.SelectSingleNode("//*[local-name()='Signature']");

            // Find the certificate node.
            var certElement = XmlDocument.SelectSingleNode("//*[local-name()='X509Certificate']");

            // Load the certificate from the certificate node.
            var cert = new X509Certificate2(Convert.FromBase64String(certElement.InnerText));

            // Load the signature node.
            signedXml.LoadXml((XmlElement)node);

            // Load the trusted certificate.
            X509Certificate2 trustedCert = new X509Certificate2("island.crt");

            // Ensure the certificate is trusted.
            if (cert.Thumbprint != trustedCert.Thumbprint) return false;

            // Determines whether the signature property verifies using the public key in the signature.
            return signedXml.CheckSignature();
        }
    }
}