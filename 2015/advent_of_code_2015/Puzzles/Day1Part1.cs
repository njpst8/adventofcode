﻿using System;

namespace Puzzle
{
    public static class Day1Part1
    {

        public static long Execute(string input)
        {
            return CalculateFloor(input);
        }

        private static long CalculateFloor(string input)
        {
            var currentFloor = 0L;
            foreach (var c in input)
            {
                if (c == '(')
                {
                    currentFloor++;
                } else if (c == ')')
                {
                    currentFloor--;
                }
            }

            return currentFloor;
        }
    }
}
