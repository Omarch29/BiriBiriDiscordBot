using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiriBiriBot.Commands
{
    public class BiriBiriComands: BaseCommandModule
    {
        [Command("cry")]
        public async Task Cry(CommandContext ctx, params string[] inputtext)
        {
            var totalstring = String.Join(' ', inputtext);
            await ctx.Channel.SendMessageAsync(iiiiiiii(totalstring)).ConfigureAwait(false);
        }

        private string iiiiiiii(string inputValue)
        {
            var vowels = new char[] { 'a', 'e', 'o', 'u' };
            var UpperVowels = new char[] { 'A', 'E', 'O', 'U' };
            var AccentVowels = new char[] { 'á', 'é', 'ó', 'ú' };
            inputValue = new string(inputValue.ToCharArray().Select(x => vowels.Any(y => y == x) ? 'i' : x).ToArray());
            inputValue = new string(inputValue.ToCharArray().Select(x => UpperVowels.Any(y => y == x) ? 'I' : x).ToArray());
            inputValue = new string(inputValue.ToCharArray().Select(x => AccentVowels.Any(y => y == x) ? 'í' : x).ToArray());
            return inputValue;

            
        }



    }


}
