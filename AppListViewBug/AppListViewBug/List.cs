using System.Collections.Generic;

namespace AppListViewBug
{
    internal class List : List<string>
    {
        public List(int capacity) : base(capacity)
        {
        }
    }
}