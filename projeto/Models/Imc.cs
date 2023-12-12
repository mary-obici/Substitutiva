namespace projeto.Models;

public class Imc
{
    public int? ImcId { get; set; }
    public int? AlunoId { get; set; }
    public Aluno? Aluno { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double? ValorImc { get; set; }
    public string? Classificacao { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;

    public void CalculaIMC()
    {
        ValorImc = Peso / (Altura * Altura);
    }

    public void VerificaImc()
    {
        if (ValorImc < 18.5)
            Classificacao = "MAGREZA";
        else if (ValorImc > 18.5 && ValorImc < 24.9)
            Classificacao = "NORMAL";
        else if (ValorImc > 25.0 && ValorImc < 29.9)
            Classificacao = "SOBREPESO";
        else if (ValorImc > 30.0 && ValorImc < 39.9)
            Classificacao = "OBESIDADE";
        else if (ValorImc > 40.0)
            Classificacao = "OBESIDADE GRAVE";
    }
}
