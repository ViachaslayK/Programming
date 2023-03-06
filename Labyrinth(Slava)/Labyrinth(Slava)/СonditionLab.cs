using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Labyrinth_Slava_
{
    public class СonditionLab
    {
        private ParametrsLab _wallsLab;

        public СonditionLab(ParametrsLab wallsLab)
        {
            _wallsLab = wallsLab;
        }

        public void BuildLaB()
        {
            RulesWalls();
            FirstPoint();
        }

        public void FirstPoint()
        {
            
            var random = new Random();
            var randomX = random.Next(_wallsLab.WIGHT);
            var randomY = random.Next(_wallsLab.HEIGHT);

            CellsLab RandomCell = _wallsLab.Cells.First(cell => cell.X == randomX && cell.Y == randomY);
            RandomCell.Earth = ' ';
            var OneStep = _wallsLab.Cells.Where(cell => cell.X == RandomCell.X && (cell.Y == RandomCell.Y - 1 || cell.Y == RandomCell.Y + 1) || cell.Y == RandomCell.Y && (cell.X == RandomCell.X - 1 || cell.X == RandomCell.X + 1)).ToList();
            OneStep.ForEach(X => X.Earth = ' ');

            CellsLab LastElement =OneStep.Last();

            ProgressGame(LastElement);


            //LastElement.AddRange(OneStep);
            //var randomNexStep = random.Next(0,OneStep.Count);
            //var randomWall = LastElement[randomNexStep];
            //randomWall.Earth = ' ';
        }

        public void ProgressGame(CellsLab LastElement)
        {
            var OneStep = _wallsLab.Cells.Where(cell => cell.X == LastElement.X && (cell.Y == LastElement.Y - 1 || cell.Y == LastElement.Y + 1) || cell.Y == LastElement.Y && (cell.X == LastElement.X - 1 || cell.X == LastElement.X + 1||LastElement.X+1<cell.X)).ToList();
            var ChechEarth = OneStep.Where(cell => cell.Earth == '#').ToList();

            if (ChechEarth.Count == 2)
            {
                return;
            }

            foreach (var cell in ChechEarth)
            {
                ProgressGame(LastElement);
            }

            OneStep.ForEach(X => X.Earth = ' ');
        }


        public void RulesWalls()
        {
            for (int y = 0; y < _wallsLab.HEIGHT; y++)
            {
                for (int x = 0; x < _wallsLab.WIGHT; x++)
                {
                    CellsLab cellsLab() => new CellsLab()
                    {
                        X = x,
                        Y = y,
                        Earth = '#'
                    };
                    _wallsLab.Cells.Add(cellsLab());
                }
            }
        }


    }
}
