﻿namespace Api17.models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int QuantidadePaginas { get; set; }
        public bool Disponivel { get; set; }
    }
}