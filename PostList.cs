using System;
using System.Text;
using System.Collections.Generic;
namespace blogApp
{
    public class PostList
    {
        private List<BlogPost> myList = new List<BlogPost>();

        public void AddPost(BlogPost temp)
        {
            myList.Add(temp);
        }

        //Find the blog post with a given id. 
        public BlogPost findPostById(int x)
        {
            foreach (BlogPost temp in myList)
            {
                if (temp.Id == x)
                {
                    return temp;
                }
            }

            return null;
        }

        //Find all posts that contain a specific word in their bodies. 
        public PostList findWordInBody(string s)
        {
            //var queryList = new PostList();
            PostList queryList = new PostList();
            foreach (BlogPost temp in myList)
            {
                if (temp.Body.Contains("boo"))
                {
                    queryList.AddPost(temp);

                }

            }
            return queryList;
        }
        //Find all posts that have a title with more than two words.
        public PostList findMoreThan2Words()
        {
            
            PostList queryList = new PostList();
            foreach (BlogPost temp in myList)
            {

                var words = temp.Body.Split(' ');
                if (words.Length > 2)
                {
                    queryList.AddPost(temp);

                }


            }return queryList;
        }
        //Find all posts written from a specific user. 
        public PostList FindPostsByWriter(string s)
        {

            PostList queryList = new PostList();
            foreach (BlogPost temp in myList)
            {

                if(temp.User.Username==s){
                    queryList.AddPost(temp);
                }


            }
            return queryList;
        }
        //Return a list of all the post ids
        public List<int> ReturnAllPostsIDs(){
            List <int> queryList = new List<int>();
            foreach (BlogPost temp in myList)
            {
                queryList.Add(temp.Id);
            }

            return queryList;
            
        }

        // A method that takes a list of the type List<BlogPost> as input (via a class, not a parameter) and returns that list in JSON format (string). 

        public string ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            foreach (BlogPost temp in myList)
            {
                sb.Append(temp.ToJSON());
                sb.Append("\n");
            }
            return sb.ToString();
        }


        /*SECOND WAY???
        public List<BlogPost> findWordInBody(List<BlogPost> temps, string s)
        {
            var queryList = new List<BlogPost>();
            foreach (BlogPost temp in temps)
            {
                if (temp.Body.Contains(s))
                {
                    queryList.Add(temp);
                }
            }

            return queryList;
        }
        */




    }
}
