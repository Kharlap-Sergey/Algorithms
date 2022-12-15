namespace UnionFind.Abstraction
{
    public interface IUnionFind<ObjectT>
    {
        bool IsConnected(ObjectT object1, ObjectT object2);

        void Union(ObjectT object1, ObjectT object2);
    }
}
