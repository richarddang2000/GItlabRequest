// See https://aka.ms/new-console-template for more information
using CliWrap;
using CliWrap.Buffered;
using System;
using System.Diagnostics;
using System.ComponentModel;
using Newtonsoft.Json.Linq;

namespace GitlabApiTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //try to run all commands
            //catch expections
            //finally close program
            try
            {
                var projID = "40018242";
                var privateToken = "glpat-c84ymaUDSgGS9KUR613S";
                var parentBranch = "main";
                var childBranch = "newBranch";
                var commitMessage = "newcommit";
                var title = "codechange";

                Request createRequest = new Request(projID, privateToken, parentBranch, childBranch);
                Request updateRequest = createRequest;
                Request mergeRequest = new Request(projID, parentBranch, childBranch, privateToken, title);

                createRequest.createNewBranch(createRequest);
                updateRequest.updateBranch(updateRequest);
                JToken MRID = mergeRequest.createMR(mergeRequest);

                Request merge = new Request(projID, privateToken, MRID);
                merge.mergeBranch(merge);
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                //
            }

        }


    }
}
