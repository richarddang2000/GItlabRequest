using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GitlabApiTest
{
    internal class Request
    {
        public string projID;
        public string targetbranch;
        public string sourcebranch;
        public string privatetoken;
        public string commitmessage;
        public string title;
        public JToken MRID;

        public Request(string _projID, string _targetbranch, string _sourcebranch, string _privatetoken, string _title) //default/ merge
        {
            projID = _projID;
            targetbranch = _targetbranch;
            sourcebranch = _sourcebranch;
            privatetoken = _privatetoken;
            title = _title;
        }

        public Request(string _projID, string _privatetoken) //get repo
        {
            projID = _projID;
            privatetoken = _privatetoken;

        }

        public Request(string _projID, string _privatetoken, JToken _MRID) //merge an MR
        {
            projID = _projID;
            privatetoken = _privatetoken;
            MRID = _MRID;

        }

        public Request(string _projID, string _privatetoken, string _sourcebranch, string _targetbranch) //create bew branch or update
        {
            projID = _projID;
            privatetoken = _privatetoken;
            sourcebranch = _sourcebranch;
            targetbranch = _targetbranch;
        }


        public void getRepo(Request r)
        {
            var command = string.Format("curl --header 'PRIVATE - TOKEN: {0}' 'https://gitlab.com/api/v4/projects/{1}/repository/files/test-config.yml?ref=main'", r.privatetoken, r.projID);
            var response = Script.executeCommand(command);
        }

        public void createNewBranch(Request r)
        {
            var command = string.Format("curl --request POST 'https://gitlab.com/api/v4/projects/{0}/repository/branches?branch={1}&ref={2}&private_token={3}'", r.projID, r.targetbranch, r.sourcebranch, r.privatetoken);
            var response = Script.executeCommand(command);
        }

        public void updateBranch(Request r)
        {
            // URL encoding: tab = %09, space = %20, linefeed = %0a \ = %5c, " = %22, : = %3a, { = %7b, } = %7d
            var encodedUpdate = Script.encodedUpdate();
            var command = string.Format("curl --request PUT 'https://gitlab.com/api/v4/projects/40018242/repository/files/newfile.yml?ref=main&branch=newBranch&author_name=richard&content={0}&commit_message=test%20commit&private_token=glpat-c84ymaUDSgGS9KUR613S'", encodedUpdate);
            //var command = "curl --request PUT --header \"Content-Type: application/json\" --data '{\"branch\": \"newBranch\", \"author_email\": \"rnd0318@tamu.edu\", \"author_name\": \"Richard Dang\", \"content\": \"content\", \"commit_message\": \"update file\"}' 'https://gitlab.com/api/v4/projects/40018242/repository/files/newfile.yml?ref=main&private_token=glpat-c84ymaUDSgGS9KUR613S'";
            var response = Script.executeCommand(command);
        }

        public JToken createMR(Request r)
        {
            var command = string.Format("curl --request POST 'https://gitlab.com/api/v4/projects/{0}/merge_requests/?source_branch={1}&target_branch={2}&title={3}&private_token={4}'", r.projID, r.sourcebranch, r.targetbranch, r.title, r.privatetoken);
            var response = Script.executeCommand(command);

            return response["iid"];
        }

        public void mergeBranch(Request r)
        {
            var command = string.Format("curl --request PUT 'https://gitlab.com/api/v4/projects/{0}/merge_requests/{1}/merge/?private_token={2}'", r.projID, r.MRID, r.privatetoken);
            var response = Script.executeCommand(command);
            //
        }
    }
}
