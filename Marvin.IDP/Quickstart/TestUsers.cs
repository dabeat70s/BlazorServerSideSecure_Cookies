// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Marvin.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "06c71238-0137-4df6-bb6a-e50e62a4a7c5", Username = "CQ", Password = "P@ssw0rd",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "CQ DaBeatLEJ"),
                    new Claim(JwtClaimTypes.GivenName, "CQ"),
                    new Claim(JwtClaimTypes.FamilyName, "DaBeatLEJ"),
                    new Claim(JwtClaimTypes.Email, "CQ@DaBeatLEJ.com"),
                    new Claim("country", "JA")
                }
            },
            new TestUser{SubjectId = "37d0f2fa-1069-489f-9d65-48c9ba44639b", Username = "Becky", Password = "ssw0rd",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Becky Allot"),
                    new Claim(JwtClaimTypes.GivenName, "Becky"),
                    new Claim(JwtClaimTypes.FamilyName, "Allot"),
                    new Claim(JwtClaimTypes.Email, "Becky.Allot@DaBeatLEJ.com"),
                    new Claim("country", "UK")
                }
            }
        };
    }
}