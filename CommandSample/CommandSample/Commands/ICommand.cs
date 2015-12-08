
namespace CommandSample.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
