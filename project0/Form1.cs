using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project0
{
    public partial class Form1 : Form
    {
        
        User currentUser;
        List<Movie> watchedMoviesList = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
           
            currentUser = new User("Alzahra");
            label1.Text = "Watch Count: 0";
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            string movieTitle = txtMovieTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(movieTitle))
            {
                MessageBox.Show("Please enter a movie title!");
                return;
            }

            
            Movie newMovie = new Movie(movieTitle, "General", 0);

            
            currentUser.WatchMovie(newMovie);
            watchedMoviesList.Add(newMovie);

            
            label1.Text = $"Watch Count: {currentUser.WatchCount}";

            
            listWatchedMovies.Items.Add($"{newMovie.Title} - (No Rating)");

            txtMovieTitle.Clear();
        }

        
        private void btnRate_Click(object sender, EventArgs e)
        {
            
            if (listWatchedMovies.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie from the list first!");
                return;
            }

            int selectedIndex = listWatchedMovies.SelectedIndex;

            
            Movie movieToRate = watchedMoviesList[selectedIndex];

            if (movieToRate != null)
            {
                int rateValue = (int)numericUpDown1.Value;

               
                currentUser.RateMovie(movieToRate, rateValue);

                
                listWatchedMovies.Items[selectedIndex] = $"{movieToRate.Title} - Rated: {rateValue}/10";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            btnWatch_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnRate_Click(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void listWatchedMovies_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void listWatchedMovies_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtMovieTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        private int _rating;

        public int Rating
        {
            get => _rating;
            set
            {
                if (value >= 1 && value <= 10) _rating = value;
                else if (value != 0) MessageBox.Show($"[Error] Rating {value} must be 1-10");
            }
        }

        public Movie(string title, string genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }

    public class User
    {
        public string Name { get; private set; }
        public int WatchCount { get; private set; }
        private List<string> _watchedTitles = new List<string>();

        public User(string name)
        {
            Name = name;
            WatchCount = 0;
        }

        public void WatchMovie(Movie movie)
        {
            WatchCount++;
            if (!_watchedTitles.Contains(movie.Title))
                _watchedTitles.Add(movie.Title);

            MessageBox.Show($"{Name} is watching {movie.Title}");
        }

        public void RateMovie(Movie movie, int rate)
        {
            if (!_watchedTitles.Contains(movie.Title))
            {
                MessageBox.Show($"[Error] You must watch '{movie.Title}' first!");
                return;
            }

            movie.Rating = rate;
            if (rate >= 1 && rate <= 10)
                MessageBox.Show($"{Name} rated {movie.Title} as {rate}/10.");
        }
    }
}