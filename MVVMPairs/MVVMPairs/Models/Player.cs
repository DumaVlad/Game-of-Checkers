using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPairs.Models
{
    class Player : INotifyPropertyChanged
    {
        private string player_turn;
        public string Player_Turn
        {
            get { return player_turn; }
            set
            {
                player_turn = value;
                NotifyPropertyChanged("Player_Turn");
            }
        }
        private int finished;
        public int Finished
        {
            get { return finished; }
            set
            {
                finished = value;
                NotifyPropertyChanged("Finished");
            }
        }
        private int score_p1;
        public int Score_p1
        {
            get { return score_p1; }
            set
            {
                score_p1 = value;
                NotifyPropertyChanged("Score_p1");
            }
        }
        private int score_p2;
        public int Score_p2
        {
            get { return score_p2; }
            set
            {
                score_p2 = value;
                NotifyPropertyChanged("Score_p2");
            }
        }
        public Player(int pt, int finished, int score_p1, int score_p2)
        {
            this.Player_Turn = "Player" + pt + "'s turn to move!";
            this.Finished = finished;
            this.score_p1 = score_p1;
            this.score_p2 = score_p2;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
