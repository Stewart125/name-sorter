using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Tests
{
    [TestClass()]
    public class NameSorterTests
    {
        // Standard alphabet character quicksort test
        [TestMethod()]
        public void AlphabetCharacterQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "dddd", "cccc", "bbbb", "aaaa" };
            string[] sortedAlphabetArray = { "aaaa", "bbbb", "cccc", "dddd" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(unsortedAlphabetArray, sortedAlphabetArray);
        }

        // Catch incorrectly sorted list
        [TestMethod()]
        public void IncorrectlySortedQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "dddd", "cccc", "bbbb", "aaaa" };
            string[] incorrectlySortedAlphabetArray = { "aaaa", "bbbb", "dddd", "cccc" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreNotEqual(unsortedAlphabetArray, incorrectlySortedAlphabetArray);
        }

        // Duplicate entries quicksort test
        [TestMethod()]
        public void DuplicateCaseAlphabetCharacterQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "aaaa", "bbbb", "bbbb", "aaaa" };
            string[] sortedAlphabetArray = { "aaaa", "aaaa", "bbbb", "bbbb" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(unsortedAlphabetArray, sortedAlphabetArray);
        }

        // Numeric character test
        [TestMethod()]
        public void NumericCharacterQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "3333", "1111", "2222", "0000" };
            string[] sortedAlphabetArray = { "0000", "1111", "2222", "3333" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(unsortedAlphabetArray, sortedAlphabetArray);
        }

        // Alphanumeric characters quicksort test
        [TestMethod()]
        public void AlphanumericCharactersQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "a1c3", "1337", "33d3", "9cd3" };
            string[] sortedAlphabetArray = { "1337", "33d3", "9cd3", "a1c3" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(unsortedAlphabetArray, sortedAlphabetArray);
        }

        // Strings including spaces quicksort test
        [TestMethod()]
        public void StringsWithSpacesQuickSortTest()
        {
            // Arrange parameters
            string[] unsortedAlphabetArray = { "aaaa bbbb", "bbbb aaaa", "aaaa aaaa", "bbbb bbbb" };
            string[] sortedAlphabetArray = { "aaaa aaaa", "aaaa bbbb", "bbbb aaaa", "bbbb bbbb" };

            // QuickSort
            NameSorter.QuickSort(unsortedAlphabetArray, 0, unsortedAlphabetArray.Length - 1);

            // Assert
            CollectionAssert.AreEqual(unsortedAlphabetArray, sortedAlphabetArray);
        }
    }
}