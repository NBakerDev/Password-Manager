using System;
using System.Collections.Generic;
namespace PasswordManager {
    class Program {
        static void Main(string[] args) {

            var passwordManager = new Dictionary<string, string>();
            passwordManager.Add("maxtrain.com", "Pass1");
            passwordManager.Add("maxtrain2.com", "Pass2");
            passwordManager.Add("maxtrain3.com", "Pass3");
            passwordManager.Add("maxtrain4.com", "Pass4");
            passwordManager.Add("maxtrain5.com", "Pass5");
            passwordManager.Add("maxtrain6.com", "Pass6");
            passwordManager.Add("maxtrain7.com", "Pass7");
            passwordManager.Add("maxtrain8.com", "Pass8");
            passwordManager.Add("maxtrain9.com", "Pass9");

            var password = passwordManager["maxtrain.com"];
            Console.WriteLine($"The password for maxtrain.com is {password}");

            foreach (var keyvalpair in passwordManager) {
                Console.WriteLine($"The password for {keyvalpair.Key} is {keyvalpair.Value}");
            }

            var allTheKeys = passwordManager.Keys;
            var allTheValues = passwordManager.Values;

            var maxtrain = "maxtrain.com";
          var exists =   passwordManager.ContainsKey(maxtrain);
        }
    }
}
