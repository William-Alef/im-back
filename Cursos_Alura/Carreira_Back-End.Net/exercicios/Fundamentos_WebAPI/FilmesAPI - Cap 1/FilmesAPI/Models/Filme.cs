using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;
public class Filme
{
    [Required (ErrorMessage = "O filme deve conter um título.")]
    [MaxLength(200, ErrorMessage = "O título deve conter até 200 caracteres.")]
    public string Titulo { get; set; }

    [Required (ErrorMessage = "O filme deve conter um gênero.")]
    [MaxLength(50, ErrorMessage = "O Gênero deve conter até 200 caracteres.")]
    public string Genero { get; set; }

    [Required (ErrorMessage = "O filme deve conter a sua duração")]
    [Range (70, 600, ErrorMessage = "O filme deve conter de 70 até 600 minutos de duração.")]
    public int Duracao { get; set; }
}
