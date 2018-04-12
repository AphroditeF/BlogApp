using System;
namespace blogApp
{
    
    public class User
    {
        /*********  Private Id Generator for unique User IDssss  ***************/
        private static int _idGenerator = 0;   


        /*************************  Private Fields  ****************************/
        private string _username;
        private int _id;


        /***************************  Properties  ******************************/
        public int Id { 
            get { return _id; } 
        }

        public string Username
        {
            get { return _username; }
        }


        /***************************  Constructor  *****************************/
        public User(string username)

        {
            _username = username;
            _idGenerator++;                 //Creates a new unique User Id 
            _id=_idGenerator;

        }
    }
}
