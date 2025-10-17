

namespace MinimalApi.Dominio.ModelViews;

public struct Home
{
    public string Mensagem
    { get => "Bem vindo a API de Veiculos - Minimal API"; }
    public string Documentacao
    { get => "/swagger"; }
}