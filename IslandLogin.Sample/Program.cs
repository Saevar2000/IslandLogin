﻿using IslandLogin.Models;
using System;

namespace IslandLogin.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String token = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz48UmVzcG9uc2UgeG1sbnM6eHNkPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYSIgeG1sbnM6eHNpPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYS1pbnN0YW5jZSIgSUQ9Il8xMWNkZjFiZS0xZGNiLTQ0OWUtOWVmOS1mOTFjZTM2MWIxZDAiIFZlcnNpb249IjIuMCIgSXNzdWVJbnN0YW50PSIyMDIwLTA3LTE5VDIzOjE1OjIyLjMwNjE5MzRaIiBEZXN0aW5hdGlvbj0iaHR0cHM6Ly9hcGkuYml0YXIuaXMvYWNjb3VudC9pc2xhbmQiIHhtbG5zPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6cHJvdG9jb2wiPjxJc3N1ZXIgeG1sbnM9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphc3NlcnRpb24iPklubnNrcmFuaW5nPC9Jc3N1ZXI+PFNpZ25hdHVyZSB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnIyI+PFNpZ25lZEluZm8+PENhbm9uaWNhbGl6YXRpb25NZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy9UUi8yMDAxL1JFQy14bWwtYzE0bi0yMDAxMDMxNSIgLz48U2lnbmF0dXJlTWV0aG9kIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI3JzYS1zaGExIiAvPjxSZWZlcmVuY2UgVVJJPSIiPjxUcmFuc2Zvcm1zPjxUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjZW52ZWxvcGVkLXNpZ25hdHVyZSIgLz48VHJhbnNmb3JtIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMS8xMC94bWwtZXhjLWMxNG4jIiAvPjwvVHJhbnNmb3Jtcz48RGlnZXN0TWV0aG9kIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMS8wNC94bWxlbmMjc2hhMjU2IiAvPjxEaWdlc3RWYWx1ZT5rVjdUeStEVzk4UTA4eVREN0lpNUZVNmx3S1dpVzJoMlJtamEwRUorYUl3PTwvRGlnZXN0VmFsdWU+PC9SZWZlcmVuY2U+PC9TaWduZWRJbmZvPjxTaWduYXR1cmVWYWx1ZT5rbnZuTlNOS2lRcmoxeUl4azhYMzFyUXVOSkhpWTVFdHZJTGwzamJ0SFhYczJsbXd3RnpEL2UwWjl6dXVHRGpDVDdtcG5CS2ZhQlBtTGFqVmlwVnpSMXIrUGUwcTRibW9VdTdKSjdRMzZUR2IvVXRmZGhPU1JQSDNvcFZiMzdRNmJzYWlKV05tQ2ZBNmRMbCtHL3NSTHBPTGU3eWxzYWY5Y0RUTWlOSVY1YjBxQndyc0RpN1lJQmlEdG1GK2IwU3R2MHFNNGJRZno2Njc5cE5XRkNjSmNMWFZ6Z0F2Uk5kZGF1ckM1Z29xZTBuOWF5YThPSzB6TjhmeUFHTGFpNlU2dTBjaktrOTYrMElYdGlZQWFoczlHVllXdW1uNWpYdC9uWWpCcjF0ekFsYnFyZTMxV2VQNzE1OUxWUE5pNm03QWIxRDNQdVJha1U0dFRMZ3RqR3hvbWc9PTwvU2lnbmF0dXJlVmFsdWU+PEtleUluZm8+PFg1MDlEYXRhPjxYNTA5Q2VydGlmaWNhdGU+TUlJR0REQ0NCUFNnQXdJQkFnSUNMTGN3RFFZSktvWklodmNOQVFFRkJRQXdnWkl4Q3pBSkJnTlZCQVlUQWtsVE1STXdFUVlEVlFRRkV3bzFNakV3TURBeU56a3dNUll3RkFZRFZRUUtFdzFCZFdSclpXNXVhU0JsYUdZdU1TTXdJUVlEVlFRTEV4cFZkR2RsWm1GdVpHa2dZblZ1WVdSaGNuTnJhV3h5YVd0cVlURVdNQlFHQTFVRUN4TU5UV2xzYkdsemEybHNjbWxyYVRFWk1CY0dBMVVFQXhNUVZISmhkWE4wZFhJZ1luVnVZV1IxY2pBZUZ3MHhPREEzTURNeE5USTBORGhhRncweU1UQTNNRE14TlRJME5EaGFNSUhDTVFzd0NRWURWUVFHRXdKSlV6RWVNQndHQTFVRUNnd1Z3NTVxdzdQRHNITnJjc09oSU1PTmMyeGhibVJ6TVJnd0ZnWURWUVFMRXc5Q2RXNWhaR0Z5YzJ0cGJISnBhMmt4SlRBakJnTlZCQXNNSEZWdVpHbHljbWwwZFc0Z1pjT3dZU0JoZGNPd2EyVnVibWx1WnlBeEhUQWJCZ2txaGtpRzl3MEJDUUVXRG5abGNtdEFhWE5zWVc1a0xtbHpNUk13RVFZRFZRUUZFd28yTlRBek56WXdOalE1TVI0d0hBWURWUVFERXhWSmJtNXphM0poYm1sdVp5QkpjMnhoYm1RdWFYTXdnZ0VpTUEwR0NTcUdTSWIzRFFFQkFRVUFBNElCRHdBd2dnRUtBb0lCQVFDNHF0bWJQTEtLd1lyZ2ZYQkhGL3RiQTQ4bnpnbE5mZ3N1NmZTdWRSZXdnRHo0by9hL0R0ZFY3OWxuTjJOZFhDNWRzQTJSaUtYMVFvSWhYdHBQSGs1T21qYzFJN3JkamhRZEFBejdnRFc5b3FBQ0h4NENvUXJTazZ6OEJaL2VxanVUM0UrN0V3ckFhR2ZDd0Q1WWMxSkVsYlVKZXl1dVNKQmdIVVd5a3g3eDFGbGVuYzMraThocHc5RTBZMmt0ajJBaVJkNStCdjZXR2k3bjUwYy9Ba2o0YnZjVTZkYXZES0ViZGVWazZsWHhBYzlCcmJOWmNvMEw2ZkUvd3RxdEtxNlk5d1VHZlgva0dkWms1d3hSK05MT2c4QlhHS2VmTHNZODQ5Sk1yTXNuNUEya0RpRjg2eGdqRFFYS0ZldEJzV1Y0eVY4S2NoaDJ6dkNvcHFaYnhuVmRBZ01CQUFHamdnSTRNSUlDTkRBTUJnTlZIUk1CQWY4RUFqQUFNSUlCSEFZRFZSMGdCSUlCRXpDQ0FROHdnZ0VMQmdsZ2dtQUJBZ0VCQkFFd2dmMHdnY1FHQ0NzR0FRVUZCd0lDTUlHM0dvRzBWR2hwY3lCalpYSjBhV1pwWTJGMFpTQnBjeUJwYm5SbGJtUmxaQ0JtYjNJZ1pHbG5hWFJoYkNCemFXZHVZWFIxY21WeklHRnVaQ0JoZFhSb1pXNTBhV05oZEdsdmJpNGdWR2hwY3lCalpYSjBhV1pwWTJGMFpTQm1kV3htYVd4eklIUm9aU0J5WlhGMWFYSmxiV1Z1ZEhNZ2IyWWdibTl5YldGc2FYcGxaQ0JqWlhKMGFXWnBZMkYwWlNCd2IyeHBZM2tnS0U1RFVDa2daR1ZtYVc1bFpDQnBiaUJGVkZOSklGUlRJREV3TWlBd05ESXVNRFFHQ0NzR0FRVUZCd0lCRmlob2RIUndPaTh2WTNBdVlYVmthMlZ1Ym1rdWFYTXZkSEpoZFhOMGRYSmlkVzVoWkhWeUwyTndNSE1HQ0NzR0FRVUZCd0VCQkdjd1pUQWpCZ2dyQmdFRkJRY3dBb1lYYUhSMGNEb3ZMMjlqYzNBdVlYVmthMlZ1Ym1rdWFYTXdQZ1lIWUlKZ0FnRmpCb1l6YUhSMGNEb3ZMMk5rY0M1aGRXUnJaVzV1YVM1cGN5OXphMmxzY21scmFTOTBjbUYxYzNSMWNtSjFibUZrZFhJdWNEZGlNQXNHQTFVZER3UUVBd0lGNERBZkJnTlZIU01FR0RBV2dCUnY3TnNSTEFFRGF4dGdycmI0YU5sQUFjMk9PREJDQmdOVkhSOEVPekE1TURlZ05hQXpoakZvZEhSd09pOHZZM0pzTG1GMVpHdGxibTVwTG1sekwzUnlZWFZ6ZEhWeVluVnVZV1IxY2k5c1lYUmxjM1F1WTNKc01CMEdBMVVkRGdRV0JCU3pVeUxlNFJDU09CSW5rSUJzTzVGeHl0RGZNakFOQmdrcWhraUc5dzBCQVFVRkFBT0NBUUVBdmpnbkg2Tm1McXNVcndvR1lzTDA3dy9TNHZKOXM4SlBVTHBtSUxGQjZoSUtxV3ZVaUpvYjdSOWxzTHBLMm94NGVMVi8vdXJCbERBU0lGWDFoR2MxVnZOdUFTaDRyQ1cvak1aR1Uwano4Sm1saWwzbTAxUFo1VGNhR1haVlFtZC84YmlOamVrYnlzS2NXekJ6Q0JHZGZhdklJdmdKeGkyaFVYM1NOZU5IaVg1V2xlcitVT3pOakhzQW11RE1kNjVuQll6ZENGeTE4REJadkk2NmxOMDMxRlRuVG44YmhaYndEWkthRnhGdzZKVFNpZnViRGpJVVJaaDJJa1ZNMFIxNXp4Zmp1Tmo1bFpsMWJmbDdUU0N2NHZsd0hHVlpYWUtUdmNqUmduZWVMYlE3cDJFTWw2L29kNC9UZkNCM1NHL1ppQWVnN0czYkc3UWI1b1NTRis0WFZnPT08L1g1MDlDZXJ0aWZpY2F0ZT48L1g1MDlEYXRhPjwvS2V5SW5mbz48L1NpZ25hdHVyZT48U3RhdHVzPjxTdGF0dXNDb2RlIFZhbHVlPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6c3RhdHVzOlN1Y2Nlc3MiIC8+PC9TdGF0dXM+PEFzc2VydGlvbiBWZXJzaW9uPSIyLjAiIElEPSJfNzE3ZDUxYmEtOWU3Ni00MTBiLTk1MzktZmI5MDg0N2U3OTEwIiBJc3N1ZUluc3RhbnQ9IjIwMjAtMDctMTlUMjM6MTU6MjIuMzA2MTkzNFoiIHhtbG5zPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXNzZXJ0aW9uIj48SXNzdWVyPklubnNrcmFuaW5nPC9Jc3N1ZXI+PFN1YmplY3Q+PE5hbWVJRCBOYW1lUXVhbGlmaWVyPSJpc2xhbmQuaXMiIC8+PFN1YmplY3RDb25maXJtYXRpb24gTWV0aG9kPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6Y206YmVhcmVyIj48U3ViamVjdENvbmZpcm1hdGlvbkRhdGEgQWRkcmVzcz0iODkuMTcuMTUwLjEyOSIgTm90T25PckFmdGVyPSIyMDIwLTA3LTE5VDIzOjIwOjIyLjMwNjE5MzRaIiBSZWNpcGllbnQ9Imh0dHBzOi8vYXBpLmJpdGFyLmlzL2FjY291bnQvaXNsYW5kIiAvPjwvU3ViamVjdENvbmZpcm1hdGlvbj48L1N1YmplY3Q+PENvbmRpdGlvbnMgTm90QmVmb3JlPSIyMDIwLTA3LTE5VDIzOjE0OjUyLjMwNjE5MzRaIiBOb3RPbk9yQWZ0ZXI9IjIwMjAtMDctMTlUMjM6MjA6MjIuMzA2MTkzNFoiPjxBdWRpZW5jZVJlc3RyaWN0aW9uPjxBdWRpZW5jZT5hcGkuYml0YXIuaXM8L0F1ZGllbmNlPjwvQXVkaWVuY2VSZXN0cmljdGlvbj48L0NvbmRpdGlvbnM+PEF1dGhuU3RhdGVtZW50IEF1dGhuSW5zdGFudD0iMjAyMC0wNy0xOVQyMzoxNToyMi4zMDYxOTM0WiI+PFN1YmplY3RMb2NhbGl0eSBBZGRyZXNzPSI4Mi4yMjEuODEuNjAiIC8+PEF1dGhuQ29udGV4dD48QXV0aG5Db250ZXh0Q2xhc3NSZWY+dXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFjOmNsYXNzZXM6VExTQ2xpZW50PC9BdXRobkNvbnRleHRDbGFzc1JlZj48L0F1dGhuQ29udGV4dD48L0F1dGhuU3RhdGVtZW50PjxBdHRyaWJ1dGVTdGF0ZW1lbnQ+PEF0dHJpYnV0ZSBOYW1lPSJVc2VyU1NOIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OmJhc2ljIiBGcmllbmRseU5hbWU9Iktlbm5pdGFsYSI+PEF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4c2Q6c3RyaW5nIj4wNDExMDAyNjUwPC9BdHRyaWJ1dGVWYWx1ZT48L0F0dHJpYnV0ZT48QXR0cmlidXRlIE5hbWU9Ik5hbWUiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iTmFmbiI+PEF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4c2Q6c3RyaW5nIj5Tw6Z2YXIgR3VubmFyc3NvbjwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJBdXRoZW50aWNhdGlvbiIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDpiYXNpYyIgRnJpZW5kbHlOYW1lPSJBdcOwa2VubmluZyI+PEF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4c2Q6c3RyaW5nIj5SYWZyw6ZuIHPDrW1hc2tpbHLDrWtpPC9BdHRyaWJ1dGVWYWx1ZT48L0F0dHJpYnV0ZT48QXR0cmlidXRlIE5hbWU9IklQQWRkcmVzcyIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDpiYXNpYyIgRnJpZW5kbHlOYW1lPSJJUFRhbGEiPjxBdHRyaWJ1dGVWYWx1ZSB4c2k6dHlwZT0ieHNkOnN0cmluZyI+ODkuMTcuMTUwLjEyOTwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJVc2VyQWdlbnQiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iTm90YW5kYVN0cmVuZ3VyIj48QXR0cmlidXRlVmFsdWUgeHNpOnR5cGU9InhzZDpzdHJpbmciPk1vemlsbGEvNS4wIChXaW5kb3dzIE5UIDEwLjA7IFdpbjY0OyB4NjQpIEFwcGxlV2ViS2l0LzUzNy4zNiAoS0hUTUwsIGxpa2UgR2Vja28pIENocm9tZS84My4wLjQxMDMuMTE2IFNhZmFyaS81MzcuMzY8L0F0dHJpYnV0ZVZhbHVlPjwvQXR0cmlidXRlPjxBdHRyaWJ1dGUgTmFtZT0iRGVzdGluYXRpb25TU04iIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iS2Vubml0YWxhTcOzdHRha2FuZGEiPjxBdHRyaWJ1dGVWYWx1ZSB4c2k6dHlwZT0ieHNkOnN0cmluZyI+NDcwODE4MDQyMDwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJNb2JpbGUiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iRmFyc8OtbWFuw7ptZXIiPjxBdHRyaWJ1dGVWYWx1ZSB4c2k6dHlwZT0ieHNkOnN0cmluZyI+KzM1NC02MTczODA3PC9BdHRyaWJ1dGVWYWx1ZT48L0F0dHJpYnV0ZT48L0F0dHJpYnV0ZVN0YXRlbWVudD48L0Fzc2VydGlvbj48L1Jlc3BvbnNlPg==";

            IslandLogin il = new IslandLogin(token);
            bool verified = il.Verify();

            Console.WriteLine($"Verified: {verified}");
            Console.WriteLine("=============");
            Console.WriteLine($"Audience: {il.Island.Audience}");
            Console.WriteLine($"Authentication: {il.Island.Authentication}");
            Console.WriteLine($"AuthId: {il.Island.AuthId}");
            Console.WriteLine($"Destination: {il.Island.Destination}");
            Console.WriteLine($"Id: {il.Island.Id}");
            Console.WriteLine($"IPAddress: {il.Island.IPAddress}");
            Console.WriteLine($"Name: {il.Island.Name}");
            Console.WriteLine($"NotBefore: {il.Island.NotBefore}");
            Console.WriteLine($"NotOnOrAfter: {il.Island.NotOnOrAfter}");
            Console.WriteLine($"ReceiverId: {il.Island.ReceiverId}");
            Console.WriteLine($"UserAgent: {il.Island.UserAgent}");
            Console.WriteLine($"UserId: {il.Island.UserId}");

            Console.ReadKey();
        }
    }
}
