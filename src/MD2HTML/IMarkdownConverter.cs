using MarkdownSharp;

namespace MD2HTML
{
    public interface IMarkdownConverter
    {
        string Version { get; }
        string Transform(string text);
    }
}