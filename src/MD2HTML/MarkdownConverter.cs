using System;
using MarkdownSharp;

namespace MD2HTML
{
    public class MarkdownConverter : IMarkdownConverter
    {
        private readonly Markdown _markdown;

        public MarkdownConverter(Markdown markdown)
        {
            _markdown = markdown ?? throw new ArgumentNullException(nameof(markdown));
        }

        public string Version => _markdown.Version;

        public string Transform(string text)
        {
            return _markdown.Transform(text);
        }
    }
}