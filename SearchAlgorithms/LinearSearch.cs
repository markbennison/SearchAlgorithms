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
    internal class LinearSearch
    {
        public static int Perform(double searchValue, List<double> listToSearch)
        {
            for (int i = 0; i < listToSearch.Count; i++)
            {
                if (listToSearch[i] == searchValue)
                {
                    return i;
                }
            }
        
            return -1;
        }

        public static int Perform(string searchValue, List<string> listToSearch)
        {
            for (int i = 0; i < listToSearch.Count; i++)
            {
                if (string.Compare(listToSearch[i], searchValue) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
