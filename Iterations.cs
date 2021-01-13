using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var newWords = words.Select(word => word.ToUpper());
            return newWords;
        }

        public static IEnumerable<int> Double(List<int> numbers)
        {
            var doubledList = numbers.Select(number => number * 2);
            return doubledList;
        }


        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var newList = data.Select((stringy, index) => $"{stringy} is at index {index}");
            return newList;
        }
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            return data.Where(num => num % 2 == 0);
        }

        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            return data.Where((element, index) => index % 2 == 0);
        }
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            var bestMovie = data.Where(movie => movie.Year == year && movie.Score >= 90);
            var namesOfBestMovies = bestMovie.Select(movie => movie.Name);
            return namesOfBestMovies;
        }

        public static bool EveryoneIsOdd(List<int> data)
        {
            return data.All(ele => ele % 2 != 0);
        }
        public static string FindTheNeedle(List<string> data)
        {
            var word = data.First(element => element.Contains("needle"));
            return word;


        }
        public static int FindTheNeedleIndex(List<string> data)
        {
            var needleIndex = data.FindIndex(element => element.Contains("needle"));
            return needleIndex;
        }
        public static bool SomeoneToLove(List<string> data)
        {
            var chosenWord = data.Any(element => element.Count() == 4);
            return chosenWord;
        }
    }
}