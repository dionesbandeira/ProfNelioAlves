using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfNelioAlves.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        string Title { get; set; }
        string Content { get; set; }
        int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }


        //Não tem no doagrama, mas por padrão criamos
        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }


        //Como que este post será convertidopara string
        //StringBuild responsavel em fazer a montagem de uma string do forma que mandar
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comment: ");

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();

            //return base.ToString();
        }



    }
}
