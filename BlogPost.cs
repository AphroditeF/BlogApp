using System;
using System.Collections.Generic;
using System.Text;
namespace blogApp
{
    public class BlogPost
    {

        /*********  Private Id Generator for unique User IDssss  ***************/
        private static int _idGenerator = 0;


        /*************************  Private Fields  ****************************/
        private int _id;
        private User _user;
        private string _title;
        private string _body;


        /***************************  Properties  ******************************/
        public int Id { get { return _id; } }
        public string Body { get { return _body; } }                                    
        public string Title { get { return _title; } }
        public User User { get { return _user; } }



        /***************************  Constructor  *****************************/
        public BlogPost(User user, string title, string body)
        {
            _idGenerator++;
            _id = _idGenerator;
            _user = user;
            _title = title;
            _body = body;


        }
        //Constructor for testing. It should be deleted
        public BlogPost(){
            _idGenerator++;
            _id = _idGenerator;
            User user0 = new User("Forsaken Saukon");
            _user = user0;
            _title = "Maecenas malesuada enim id eros."; //Sample  name, title and body
            _body = "Duis ac ex sapien. Etiam ultricies felis id ullamcorper dictum. Vivamus rhoncus vulputate placerat. In vel sapien mattis, ultricies massa a, mattis nisl. Fusce nisi lacus, consectetur vel auctor et, pulvinar ac massa. Nunc dignissim rhoncus massa. Pellentesque vel nibh quis ipsum laoreet tristique ut.";
        }


        /*****************************  Methods  *******************************/


        public string ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\n\"id\": \"");
            sb.Append(this.Id);
            sb.Append("\",\n\"user\": {\n\t\"id\": \"");
            sb.Append(this.User.Id);
            sb.Append("\",\n\t\"username\": \"");
            sb.Append(this.User.Username);
            sb.Append("\"\n },\n \"title\": \"");
            sb.Append(this.Title);
            sb.Append("\",\n \"body\": \"");
            sb.Append(this.Body);
            sb.Append("\"\n}");

            return sb.ToString();
        }

    }
}