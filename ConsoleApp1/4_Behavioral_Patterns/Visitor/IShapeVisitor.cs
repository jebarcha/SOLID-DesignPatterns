namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public interface IShapeVisitor
    {
        public void Visit(Square square);
        public void Visit(Circle circle);
        public void Visit(JoinShape joinShapes);
    }
}