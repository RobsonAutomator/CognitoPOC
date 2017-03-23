using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognito.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var poolId = Environment.GetEnvironmentVariable("CognitoPoolId");
            var clientId = Environment.GetEnvironmentVariable("CognitoClientId");

        }
    }
}
