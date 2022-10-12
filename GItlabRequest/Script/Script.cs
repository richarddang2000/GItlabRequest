using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using Newtonsoft.Json.Linq;

namespace GitlabApiTest
{
    internal class Script
    {
        public static JObject executeCommand(string command)
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = @"C:\Users\Richard_Dang\source\repos\GitlabApiTest\GitlabApiTest";
            processStartInfo.FileName = @"C:\Program Files\Git\bin\bash";
            processStartInfo.Arguments = " -c \"" + command + "\"";
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            Console.WriteLine(processStartInfo.Arguments);
            process.StartInfo = processStartInfo;
            process.Start();

            StringBuilder response = new StringBuilder();
            while (!process.StandardOutput.EndOfStream)
            {
                response.Append(process.StandardOutput.ReadLine());
            }
            //Console.Write(response);

            JObject jsonResponse = JObject.Parse(Convert.ToString(response));
            return jsonResponse;
        }

        public static string encodedUpdate()
        {
            var encodedUpdate = "%7b%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%09%22glossary%22%3a%20%22putting%20a%20lot%20of%20information%20here%20to%20test%20performance%20of%20api%20request%22%20%7b%0a" +
                "%09%7d%0a" +
                "%7d";

            return encodedUpdate;
        }
    }
}
