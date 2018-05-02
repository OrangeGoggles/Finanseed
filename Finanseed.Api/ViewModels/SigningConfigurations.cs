using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace Finanseed.Api.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class SigningConfigurations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SecurityKey Key { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SigningCredentials SigningCredentials { get; }

        /// <summary>
        /// 
        /// </summary>
        public SigningConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials(
                Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}