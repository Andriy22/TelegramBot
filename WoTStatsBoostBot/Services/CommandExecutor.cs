using Telegram.Bot.Types;
using WoTStatsBoostBot.Interfaces;

namespace WoTStatsBoostBot.Services
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly List<BaseCommand> _commands;
        private BaseCommand _lastCommand;

        public CommandExecutor(IServiceProvider serviceProvider)
        {
            _commands = serviceProvider.GetServices<BaseCommand>().ToList();
        }

        public async Task Execute(Update update)
        {
            if (update?.Message?.Chat == null && update?.CallbackQuery == null)
                return;

        }
    }
}
