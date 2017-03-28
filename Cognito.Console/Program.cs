using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime.Internal.Auth;

namespace Cognito.Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Just for first time setup
            //Environment.SetEnvironmentVariable("CognitoPoolId", "", EnvironmentVariableTarget.User);
            //Environment.SetEnvironmentVariable("CognitoClientId", "", EnvironmentVariableTarget.User);

            var poolId = Environment.GetEnvironmentVariable("CognitoPoolId",EnvironmentVariableTarget.User);
            var clientId = Environment.GetEnvironmentVariable("CognitoClientId", EnvironmentVariableTarget.User);


            using (var client = new AmazonCognitoIdentityProviderClient())
            {
                var response = client.DescribeUserPool(new DescribeUserPoolRequest() {UserPoolId = poolId});
                System.Console.WriteLine(response.HttpStatusCode);
            }
        }
    }
}
