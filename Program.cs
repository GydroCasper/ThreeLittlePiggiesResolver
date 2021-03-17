using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeLittlePiggiesResolver
{
    class Program
    {
        public const int DIMENSION = 4;
        public const string EMPTY = "E";
        public const string PIG = "P";
        public const string WOLF = "W";

        public static void Main()
        {
            var fields = new List<string[,]>
            {
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, PIG, PIG}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, EMPTY, PIG}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, PIG, PIG}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {PIG, EMPTY, EMPTY, EMPTY}, {PIG, EMPTY, EMPTY, PIG}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {PIG, EMPTY, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {PIG, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, PIG, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, { PIG, EMPTY, EMPTY, EMPTY}, { PIG, PIG, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, { PIG, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, PIG }, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, PIG, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, { PIG, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, PIG, PIG }, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, { PIG, PIG, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, { PIG, PIG, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, PIG }, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, PIG, PIG, null}, { PIG, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, { PIG, EMPTY, EMPTY, PIG }, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, { PIG, PIG, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, EMPTY, EMPTY, PIG }, {EMPTY, EMPTY, EMPTY, PIG }, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, { PIG, EMPTY, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, PIG, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, WOLF, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, WOLF}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, PIG }, {WOLF, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, WOLF, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, WOLF, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, WOLF, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, PIG, WOLF}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, PIG, null}, {EMPTY, WOLF, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, PIG } },
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, PIG }, { PIG, EMPTY, WOLF, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, PIG, EMPTY, null}, {EMPTY, EMPTY, EMPTY, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, WOLF, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {WOLF, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, PIG, PIG }, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, WOLF}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, PIG } },
                new[,] {{null, EMPTY, WOLF, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, PIG } },
                new[,] {{null, EMPTY, EMPTY, null}, { PIG, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, WOLF, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, WOLF, EMPTY, EMPTY}, {EMPTY, EMPTY, EMPTY, PIG }, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, WOLF, PIG, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, WOLF, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, WOLF, EMPTY}, {EMPTY, EMPTY, EMPTY, EMPTY}, {null, EMPTY, EMPTY, PIG } },
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, EMPTY, EMPTY}, {WOLF, EMPTY, EMPTY, PIG }, {null, PIG, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, EMPTY, EMPTY, WOLF}, {EMPTY, PIG, PIG, EMPTY}, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, EMPTY, EMPTY}, {EMPTY, WOLF, EMPTY, PIG }, {null, EMPTY, EMPTY, EMPTY}},
                new[,] {{null, WOLF, EMPTY, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
                new[,] {{null, EMPTY, EMPTY, null}, {EMPTY, PIG, EMPTY, EMPTY}, {EMPTY, EMPTY, WOLF, EMPTY}, {null, EMPTY, EMPTY, PIG } },
                new[,] {{null, EMPTY, WOLF, null}, {EMPTY, EMPTY, PIG, EMPTY}, {EMPTY, PIG, EMPTY, EMPTY}, {null, EMPTY, PIG, EMPTY}},
            };

            var patterns = new[]
            {
                new Pattern
                {
                    Color = Colors.Yellow,
                    Rotations = new[] {new Directions {Down = 1, Left = 1}, new Directions {Left = 1, Up = 1}, new Directions {Up = 1, Right = 1}, new Directions {Right = 1, Down = 1}}
                },
                new Pattern
                {
                    Color = Colors.Red,
                    Rotations = new[] {new Directions {Down = 2, Left = 1}, new Directions {Left = 2, Up = 1}, new Directions {Up = 2, Right = 1}, new Directions {Right = 2, Down = 1}}
                },
                new Pattern
                {
                    Color = Colors.Brown,
                    Rotations = new[] {new Directions {Down = 1, Up = 1}, new Directions {Left = 1, Right = 1}}
                }
            };

            for (var i = 0; i < fields.Count; i++)
            {
                Console.WriteLine(i+1);
                PaintSolution(patterns, fields[i]);
                Console.WriteLine("===================================================");
            }

            Console.ReadKey();
        }

        private static void PaintSolution(Pattern[] patterns, string[,] field)
        {
            var point = new Coordinates {X = 0, Y = 0};

            var isWolf = CheckIsWolf(field);

            string[,] result = null;

            while (CheckIsNotTheEnd(point))
            {
                var (isFit, modifiedField) = TryPoint(point, patterns, field, isWolf);

                if (isFit)
                {
                    result = modifiedField;
                    break;
                }

                point = MovePoint(point);
            }

            Paint(field, result);
        }

        private static bool CheckIsWolf(string[,] field)
        {
            return CheckIsChip(field, WOLF);
        }

        private static bool CheckIsPig(string[,] field)
        {
            return CheckIsChip(field, PIG);
        }

        private static bool CheckIsChip(string[,] field, string chip)
        {
            for (var i = 0; i < DIMENSION; i++)
            {
                for (var j = 0; j < DIMENSION; j++)
                {
                    if (field[i, j] == chip) return true;
                }
            }

            return false;
        }

        public static (bool, string[,]) TryPoint(Coordinates point, Pattern[] patterns, string[,] field, bool isWolf)
        {
            if (field[point.X, point.Y] == null) return (false, null);
            if (isWolf && field[point.X, point.Y] != PIG && field[point.X, point.Y] != EMPTY) return (false, null);
            if (!isWolf && field[point.X, point.Y] != EMPTY) return (false, null);

            foreach (var pattern in patterns)
            {
                foreach (var rotation in pattern.Rotations)
                {
                    var (isPatternFitToPoint, probableField) = TryPointRotation(point, rotation, pattern.Color, field);

                    if (isPatternFitToPoint)
                    {
                        if (patterns.Length == 1)
                        {
                            if(!isWolf) return (true, probableField);
                            if(!CheckIsPig(probableField)) return (true, probableField);
                        }

                        var nextPoint = MovePoint(point);

                        while (CheckIsNotTheEnd(nextPoint))
                        {
                            var (isPatternFitsToTheRemainingPoints, modifiedField) = TryPoint(nextPoint, patterns.Where(x => x != pattern).ToArray(), probableField, isWolf);
                            if (isPatternFitsToTheRemainingPoints) return (true, modifiedField);
                            nextPoint = MovePoint(nextPoint);
                        }
                    }
                }
            }

            return (false, null);
        }

        public static (bool, string[,]) TryPointRotation(Coordinates point, Directions rotation, Colors color, string[,] field)
        {
            if (point.X < rotation.Left) return (false, null);
            if (point.Y < rotation.Up) return (false, null);
            if (point.X + rotation.Right >= DIMENSION) return (false, null);
            if (point.Y + rotation.Down >= DIMENSION) return (false, null);

            var probableField = Copy(field);
            var i = 1;

            while (i <= rotation.Left)
            {
                if (probableField[point.X - i, point.Y] != EMPTY) return (false, null);
                probableField[point.X - i++, point.Y] = color.ToString();
            }

            i = 1;

            while (i <= rotation.Up)
            {
                if (probableField[point.X, point.Y - i] != EMPTY) return (false, null);
                probableField[point.X, point.Y - i++] = color.ToString();
            }

            i = 1;

            while (i <= rotation.Right)
            {
                if (probableField[point.X + i, point.Y] != EMPTY) return (false, null);
                probableField[point.X + i++, point.Y] = color.ToString();
            }

            i = 1;

            while (i <= rotation.Down)
            {
                if (probableField[point.X, point.Y + i] != EMPTY) return (false, null);
                probableField[point.X, point.Y + i++] = color.ToString();
            }

            probableField[point.X, point.Y] = color.ToString();

            return (true, probableField);
        }

        public static string[,] Copy(string[,] field)
        {
            var result = new string[DIMENSION, DIMENSION];

            for (var i = 0; i < DIMENSION; i++)
            {
                for (var j = 0; j < DIMENSION; j++)
                {
                    result[i, j] = field[i, j];
                }
            }

            return result;
        }

        public static Coordinates MovePoint(Coordinates point)
        {
            return point.X < DIMENSION - 1 ? new Coordinates {X = point.X + 1, Y = point.Y} : new Coordinates {X = 0, Y = point.Y + 1};
        }

        public static bool CheckIsNotTheEnd(Coordinates point)
        {
            return point.X < DIMENSION && point.Y < DIMENSION;
        }

        public static void Paint(string[,] originalField, string[,] modifiedField)
        {
            for (var i = 0; i < DIMENSION; i++)
            {
                PaintRow(originalField, i);

                Console.Write(i == 2 ? "   =>   " : "        ");

                PaintRow(modifiedField, i);

                Console.WriteLine();
            }
        }

        private static void PaintRow(string[,] originalField, int rowNum)
        {
            for (var j = 0; j < DIMENSION; j++)
            {
                var value = originalField[j, rowNum] != null ? originalField[j, rowNum] : " ";

                if (value == EMPTY)
                {
                    value = "*";
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (value == PIG) Console.ForegroundColor = ConsoleColor.DarkMagenta;

                if (value == Colors.Brown.ToString())
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    value = " ";
                }

                if (value == Colors.Yellow.ToString())
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    value = " ";
                }

                if (value == Colors.Red.ToString())
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    value = " ";
                }

                Console.Write($"{value} ", ConsoleColor.Blue);

                Console.ResetColor();
            }
        }
    }
}
