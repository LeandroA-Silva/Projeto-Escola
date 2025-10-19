using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A placa do veículo é obrigatória.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O ano de fabricação é obrigatório.")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O ano do modelo é obrigatório.")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
