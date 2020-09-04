﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace Yatzy.MVVM
{
    class DragDropViewModel:BaseViewModel
    {
        /// <summary>
        /// dictionary som håller
        /// 1 placeringen
        /// 2 färgen
        /// </summary>
        public Dictionary<int, int> PlacedPegs { get; set; } = new Dictionary<int, int>();

        public ObservableCollection<int> MyProperty { get; set; }

        

        public bool IsCorrect { get; set; } = true;

        private void ploj ()
        {

            //MyProperty.Remove(3);
            PegPosition peg;
            peg = new PegPosition();
            
            switch (peg)
            {
                case PegPosition.CorrectColorWrongPosition:
                    break;
                case PegPosition.CorrectColorAndPosition:
                    break;
                case PegPosition.TotalyWrong:
                    break;
                default:
                    break;
            }
        }

        //private Dictionary<string, Brush>

        // Färgindex 2, på plats 1
    }
}
