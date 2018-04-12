using System;
using System.Collections.Generic;

namespace blogApp
{
    class MainClass
    {
        protected static void Main(string[] args)
        {



            Console.WriteLine(@"                       ,/\,,,,/\,.");
            Console.WriteLine(@"                      =          =,");          //http://www.asciiworld.com/-Cats-.html
            Console.WriteLine(@"                     =` '<Q> <Q>'  =,          Welcome to the cat blog!!");
            Console.WriteLine(@"          ,=~~~~~~~~~`=     Y    =,`;,");
            Console.WriteLine(@"        ,='            // :-^-; \\  `;");
            Console.WriteLine(@"      ,='       `      ,,,,.'       :;");
            Console.WriteLine(@"      ;,        '`          ':      `;");
            Console.WriteLine(@"      ;`         ;',          ::,   ;;");
            Console.WriteLine(@"      '\`   `,`';'`'`;`'`;';,  `; ':;");
            Console.WriteLine(@"       '\`  '`\;~~~;/~~;~;/\`,  ';'`;");
            Console.WriteLine(@"       /#\`  `'\#############)),';~#\");
            Console.WriteLine(@"      /##\`  '`\\############))_;####\");
            Console.WriteLine(@"     |###\`'`'\MMMMMMMMMMMMMMMMMMMMMM| ");
            Console.WriteLine(@"     | NNNN\`'`\NNNNNNNNNNNNNNNNNNNNNN| ");
            Console.WriteLine(@"     | YYYYY`\\`YYYYYYYYYYYYYYYYYYYYYY | ");



            User user1 = new User("Furious Wanydd");            //http://www.namegenerator.biz/vampire-name-generator.php
            User user2 = new User("Lord Sevilith");
            User user3 = new User("Ruthless Adwiemeth");


            //https://www.lipsum.com/

            //Testing Values 
            PostList posts2018_11_4 = new PostList();

            posts2018_11_4.AddPost(new BlogPost(user1, "dolor sit amet","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam consequat venenatis mi, scelerisque molestie sem egestas quis. Mauris imperdiet urna nibh, vitae placerat est pharetra sit amet. Phasellus faucibus magna sit amet iaculis gravida. Nulla quis magna placerat, gravida nibh et, ultrices nisi. Pellentesque lobortis tellus quis elit lacinia aliquam. Nunc gravida tortor eget enim venenatis, vel consectetur lorem rhoncus. Vestibulum velit lorem, tincidunt et nibh eu, posuere vulputate ligula. Quisque commodo mattis iaculis.Nulla facilisi.Fusce volutpat libero et varius laoreet.Sed sit amet tellus non ipsum aliquet ultricies ac sed nulla.Aenean viverra lectus in vestibulum bibendum.Donec velit quam, pharetra at elementum sed, feugiat ut mauris.Nulla vitae porttitor libero.In id libero porttitor, feugiat lorem eget, ullamcorper dui.Integer efficitur ipsum eget malesuada ultricies.Vestibulum volutpat mollis egestas.Suspendisse sed velit et purus bibendum porttitor in ut purus.Aenean molestie mollis quam vitae tincidunt. Suspendisse sed odio eros.Integer varius felis diam, a lacinia mauris dictum vitae.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Phasellus tempus mattis velit, rhoncus blandit mi sagittis eu.In fermentum sagittis fermentum.Morbi eleifend metus elit, sed feugiat neque sodales eu.Suspendisse enim arcu, facilisis et dignissim vel, mollis ac nisl.Aliquam pharetra, diam in pharetra porta, odio leo facilisis nibh, sit amet posuere velit dui eget ante.Nulla ipsum turpis, aliquam mattis eros et, tempus ullamcorper quam.Vivamus varius risus id consectetur auctor.Pellentesque et commodo sem, a aliquam lorem.Donec ut mollis nisi, ut condimentum urna."));
            posts2018_11_4.AddPost(new BlogPost(user3, "nulla sit amet ultrices vulputate", "Vestibulum tincidunt, nulla sit amet ultrices vulputate, tellus massa dignissim urna, mattis pulvinar justo lacus ac felis. Duis vitae ante magna. Aliquam consectetur laoreet dui, ac facilisis libero blandit at. Integer ut molestie risus. Cras ut iaculis velit, quis lacinia lectus. Proin eleifend eros quis mollis sodales. Sed sodales elit ut rutrum molestie. Proin a elit diam. Sed vitae augue cursus, faucibus diam eget, scelerisque massa. Nam vitae tortor ac diam fermentum rutrum eu molestie diam."));
            posts2018_11_4.AddPost(new BlogPost(user1, "Class aptent taciti sociosqu", "Class boo aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec sollicitudin, ipsum a eleifend dignissim, metus est vulputate neque, sed finibus arcu quam vitae nibh. Sed ut magna eu lacus sagittis vestibulum. Nulla justo nisl, fringilla non mattis nec, lobortis nec risus. Quisque fermentum ut urna eget ultrices. Praesent semper sagittis est vitae dictum. Vestibulum lorem urna, scelerisque sed egestas vitae, sagittis a tortor. Donec tortor purus, fermentum ut euismod nec, viverra ut nisi. Ut suscipit a lorem sit amet mollis. Vestibulum non sem ac nunc fermentum aliquam."));
            posts2018_11_4.AddPost(new BlogPost(user2, "Duis sed pulvinar urna", "Praesent ut turpis eu turpis tincidunt porta. Duis sed pulvinar urna. Ut scelerisque orci in neque tincidunt, et facilisis ipsum ornare. Sed euismod dolor in accumsan commodo. Aenean mi dui, lacinia in leo ac, aliquam placerat enim. Vestibulum eu sem posuere, aliquet nisl tincidunt, vestibulum tellus. Mauris et varius sapien."));
            posts2018_11_4.AddPost(new BlogPost(user2, "Phasellus at orci", "Praesent scelerisque leo ac sapien hendrerit pharetra nec vitae diam. Phasellus at orci ac mi pretium bibendum. Sed venenatis risus ligula, et dignissim est ornare eu. Aenean ornare neque vel elit ornare, eget convallis metus faucibus. Duis a pulvinar felis."));
            posts2018_11_4.AddPost(new BlogPost(user2, "Phasellus at orci", "Praesent boo"));


            //test quest1
            BlogPost test=new BlogPost();
            test=posts2018_11_4.findPostById(2);
            string message=test.ToJSON();
            Console.WriteLine(message);

            //test quest 2
            Console.WriteLine("****************************************");
            Console.WriteLine("quest2");

            PostList query2 = new PostList();
            query2 = posts2018_11_4.findWordInBody("boo");
            string message2 = query2.ToJSON();
            Console.WriteLine(message2);
            //test=posts2018_11_4.f

            //test quest 3

            Console.WriteLine("****************************************");
            Console.WriteLine("quest3");

            PostList query3 = new PostList();
            query3 = posts2018_11_4.findMoreThan2Words();
            string message3 = query3.ToJSON();
            Console.WriteLine(message3);

            //test quest 4

            Console.WriteLine("****************************************");
            Console.WriteLine("quest4");

            PostList query4 = new PostList();
            query4 = posts2018_11_4.FindPostsByWriter("Lord Sevilith");
            string message4 = query4.ToJSON();
            Console.WriteLine(message4);

            //test quest 5

            Console.WriteLine("****************************************");
            Console.WriteLine("quest5");

            List<int> query5 = new List<int>();
            query5 = posts2018_11_4.ReturnAllPostsIDs();

            foreach (int temp in query5)
                {
                Console.WriteLine(temp);
                }

            Console.ReadKey();

            /* SECOND WAY????
            List<BlogPost> posts2018_11_4 = new List<BlogPost>();

            posts2018_11_4.Add(new BlogPost(user1, "dolor sit amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam consequat venenatis mi, scelerisque molestie sem egestas quis. Mauris imperdiet urna nibh, vitae placerat est pharetra sit amet. Phasellus faucibus magna sit amet iaculis gravida. Nulla quis magna placerat, gravida nibh et, ultrices nisi. Pellentesque lobortis tellus quis elit lacinia aliquam. Nunc gravida tortor eget enim venenatis, vel consectetur lorem rhoncus. Vestibulum velit lorem, tincidunt et nibh eu, posuere vulputate ligula. Quisque commodo mattis iaculis.Nulla facilisi.Fusce volutpat libero et varius laoreet.Sed sit amet tellus non ipsum aliquet ultricies ac sed nulla.Aenean viverra lectus in vestibulum bibendum.Donec velit quam, pharetra at elementum sed, feugiat ut mauris.Nulla vitae porttitor libero.In id libero porttitor, feugiat lorem eget, ullamcorper dui.Integer efficitur ipsum eget malesuada ultricies.Vestibulum volutpat mollis egestas.Suspendisse sed velit et purus bibendum porttitor in ut purus.Aenean molestie mollis quam vitae tincidunt. Suspendisse sed odio eros.Integer varius felis diam, a lacinia mauris dictum vitae.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Phasellus tempus mattis velit, rhoncus blandit mi sagittis eu.In fermentum sagittis fermentum.Morbi eleifend metus elit, sed feugiat neque sodales eu.Suspendisse enim arcu, facilisis et dignissim vel, mollis ac nisl.Aliquam pharetra, diam in pharetra porta, odio leo facilisis nibh, sit amet posuere velit dui eget ante.Nulla ipsum turpis, aliquam mattis eros et, tempus ullamcorper quam.Vivamus varius risus id consectetur auctor.Pellentesque et commodo sem, a aliquam lorem.Donec ut mollis nisi, ut condimentum urna."));
            posts2018_11_4.Add(new BlogPost(user3, "nulla sit amet ultrices vulputate", "Vestibulum tincidunt, nulla sit amet ultrices vulputate, tellus massa dignissim urna, mattis pulvinar justo lacus ac felis. Duis vitae ante magna. Aliquam consectetur laoreet dui, ac facilisis libero blandit at. Integer ut molestie risus. Cras ut iaculis velit, quis lacinia lectus. Proin eleifend eros quis mollis sodales. Sed sodales elit ut rutrum molestie. Proin a elit diam. Sed vitae augue cursus, faucibus diam eget, scelerisque massa. Nam vitae tortor ac diam fermentum rutrum eu molestie diam."));
            posts2018_11_4.Add(new BlogPost(user1, "Class aptent taciti sociosqu", "Class boo aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec sollicitudin, ipsum a eleifend dignissim, metus est vulputate neque, sed finibus arcu quam vitae nibh. Sed ut magna eu lacus sagittis vestibulum. Nulla justo nisl, fringilla non mattis nec, lobortis nec risus. Quisque fermentum ut urna eget ultrices. Praesent semper sagittis est vitae dictum. Vestibulum lorem urna, scelerisque sed egestas vitae, sagittis a tortor. Donec tortor purus, fermentum ut euismod nec, viverra ut nisi. Ut suscipit a lorem sit amet mollis. Vestibulum non sem ac nunc fermentum aliquam."));
            posts2018_11_4.Add(new BlogPost(user2, "Duis sed pulvinar urna", "Praesent ut turpis eu turpis tincidunt porta. Duis sed pulvinar urna. Ut scelerisque orci in neque tincidunt, et facilisis ipsum ornare. Sed euismod dolor in accumsan commodo. Aenean mi dui, lacinia in leo ac, aliquam placerat enim. Vestibulum eu sem posuere, aliquet nisl tincidunt, vestibulum tellus. Mauris et varius sapien."));
            posts2018_11_4.Add(new BlogPost(user2, "Phasellus at orci", "Praesent scelerisque leo ac sapien hendrerit pharetra nec vitae diam. Phasellus at orci ac mi pretium bibendum. Sed venenatis risus ligula, et dignissim est ornare eu. Aenean ornare neque vel elit ornare, eget convallis metus faucibus. Duis a pulvinar felis."));
            */



        }
    }
}
