from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
import bot_commands as cmd


app = ApplicationBuilder().token("5865924341:AAEbIJEFG9eDO5S6MTsecQaEpeDlKv8P4aQ").build()

app.add_handler(CommandHandler("hi", cmd.hi_command))
app.add_handler(CommandHandler("help", cmd.help_command))
app.add_handler(CommandHandler("time", cmd.time_command))
app.add_handler(CommandHandler("sum", cmd.sum_command))
print('server start')
app.run_polling()
