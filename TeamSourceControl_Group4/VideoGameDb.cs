using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TeamSourceControl_Group4
{
    class VideoGameDb
    {
        public static List<VideoGame> GetVideoGames()
        {
            using (VideoGameContext context = new VideoGameContext())
            {
                List<VideoGame> allGames =
                    (from prod in context.VideoGames
                     select prod).ToList();



                return allGames;
            }
        }

        public static VideoGame Insert(VideoGame g)
        {
            using (var context = new VideoGameContext())
            {
                context.VideoGames.Add(g);
                context.SaveChanges();

                return g;
            }
        }

        public static VideoGame Update(VideoGame g)
        {
            using (var context = new VideoGameContext())
            {
                context.Entry(g).State = EntityState.Modified;

                context.SaveChanges();

                return g;
            }
        }

        public static void Delete(VideoGame g)
        {
            using (var context = new VideoGameContext())
            {
                context.Entry(g).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var context = new VideoGameContext())
            {
                VideoGame gameToDelete =
                    (from g in context.VideoGames
                     where g.GameId == id
                     select g).Single();


                context.Entry(gameToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
