/* *************************************************************************** *
 * *************************************************************************** *
 *       __  ___           __       ____                   _                   *
 *      /  |/  /___ ______/ /__    / __ )___  ____  ____  (_)________  ____    *
 *     / /|_/ / __ `/ ___/ //_/   / __  / _ \/ __ \/ __ \/ / ___/ __ \/ __ \   *
 *    / /  / / /_/ / /  / ,<     / /_/ /  __/ / / / / / / (__  ) /_/ / / / /   *
 *   /_/  /_/\__,_/_/  /_/|_|   /_____/\___/_/ /_/_/ /_/_/____/\____/_/ /_/    *
 *                                                                             *
 * *************************************************************************** *
 * *************************************************************************** */

namespace SearchAlgorithms
{
    internal class BinarySearch
    {
        public static int Perform(double searchValue, List<double> listToSearch)
        {
            int left = 0;
            int right = listToSearch.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (listToSearch[mid] == searchValue)
                {
                    return mid; // Target found at index mid
                }
                else if (listToSearch[mid] < searchValue)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return -1; // Target not found

        }
    }
}
