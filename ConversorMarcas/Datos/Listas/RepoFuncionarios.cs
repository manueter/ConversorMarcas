using ConversorMarcas.Modelo.Entidades;

namespace ConversorMarcas.Datos.Listas
{
    public class RepoFuncionarios
    {
        private RepoFuncionarios instancia = new RepoFuncionarios();
        private List<Funcionario> funcionarios = new List<Funcionario>();
        public RepoFuncionarios GetInstancia() { return instancia; }
        public void AgregarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null) funcionarios.Add(funcionario);
        }
        public void AgregarFuncionarios(List<Funcionario> funcionarios)
        {
            if (funcionarios != null) this.funcionarios.AddRange(funcionarios);
        }
        public List<Funcionario> GetFuncionarios()
        {
            return funcionarios;
        }
        public Funcionario GetFuncionarioXNombre(string nombre)
        {
            foreach (Funcionario f in funcionarios)
            {
                if (f.Nombre == nombre) return f;
            }
            return null;
        }

    }
}