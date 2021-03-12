using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl_Group4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<VideoGame> games = VideoGameDb.GetVideoGames();
            foreach (VideoGame g in games)
            {
                gameLstBox.Items.Add(g);
            }
        }

        private void addGameBtn_Click(object sender, EventArgs e)
        {
            #region Test Code
            //var p1 = new VideoGame()
            //{
            //    Title = "GTA 5",
            //    Price = 19.99 ,
            //    Rating = "ESRB Mature"
            //};

            //VideoGameDb.Insert(p1);

            //var p2 = new VideoGame()
            //{
            //    Title = "GenShin Impact",
            //    Price = 0 ,
            //    Rating = "ESRB Teen"
            //};

            //VideoGameDb.Insert(p2);

            //p1.Price = 15.50;

            //VideoGameDb.Update(p1);

            //List<VideoGame> prods = VideoGameDb.GetVideoGames();

            //VideoGameDb.Delete(p1);

            //prods = VideoGameDb.GetVideoGames();
            //foreach(VideoGame v in prods)
            //{
            //    gameLstBox.Items.Add(v.Title);
            //}
            #endregion

            if (priceTxt.Text != "" ||
                titleTxt.Text != "" ||
                ratingCmbBxox.SelectedIndex != -1)
            {
                VideoGame game = new VideoGame()
                {
                    Title = titleTxt.Text,
                    Price = Convert.ToDouble(priceTxt.Text),
                    Rating = ratingCmbBxox.Text
                };
                gameLstBox.Items.Clear();
                VideoGameDb.Insert(game);
                List<VideoGame> games = VideoGameDb.GetVideoGames();
                foreach (VideoGame g in games)
                {
                    gameLstBox.Items.Add(g);
                }
            }

            
            
        }

        private void gameLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteGameBtn_Click(object sender, EventArgs e)
        {
            if (gameLstBox.SelectedItem != null)
            {
                VideoGame gameToBeDeleted = (VideoGame)gameLstBox.SelectedItem;
                VideoGameDb.Delete(gameToBeDeleted);
                gameLstBox.Items.Clear();
                List<VideoGame> games = VideoGameDb.GetVideoGames();
                foreach (VideoGame g in games)
                {
                    gameLstBox.Items.Add(g);
                }
            }
            
        }
    }
}
