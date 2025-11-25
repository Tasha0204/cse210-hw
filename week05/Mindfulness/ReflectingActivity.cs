public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() { }
    public void Run() { }
    public string GetRandomPrompt() { return ""; } // Declaración de retorno
    public string DisplayPrompt() { return ""; } // Declaración de retorno
    public void DisplayQuestions() { }
}