namespace Application
{
	public interface ICommand<T>
	{
		T Model { get; set; }
		void Execute();
	}
}