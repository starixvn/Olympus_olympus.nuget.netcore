using Fanex.Data.Repository;

namespace Olympus.OWP.Log.Data.Repository.Services
{
    public interface LogWriterService
    {
        Task Execute(INonQueryCommand command);
    }

    public class LogWriterServiceImp(IDynamicRepository repository) : LogWriterService
    {
        public async Task Execute(INonQueryCommand command)
        {
            await repository.ExecuteAsync(command);
        }
    }
}
