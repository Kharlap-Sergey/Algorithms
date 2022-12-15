using UnionFind.Abstraction;

namespace UnionFind.Concreet
{
    internal class QuickFind : IUnionFind<int>
    {
        private readonly int _objectsAmount;
        private int[] unions;
        public QuickFind(int objectsAmount)
        {
            unions = new int[objectsAmount];
            for(int i = 0; i < objectsAmount; i++)
            {
                unions[i] = i;
            }
            _objectsAmount = objectsAmount;
        }
        public bool IsConnected(int object1, int object2)
        {
            return unions[object1] == unions[object2];
        }

        public void Union(int object1, int object2)
        {
            if (IsConnected(object1, object2))
                return;

            var object1Id = unions[object1];
            var object2Id = unions[object2];
            for(var i = 0; i < _objectsAmount; i++)
            {
                if (unions[i] == object1Id)
                    unions[i] = object2Id;
            }
        }
    }
}
