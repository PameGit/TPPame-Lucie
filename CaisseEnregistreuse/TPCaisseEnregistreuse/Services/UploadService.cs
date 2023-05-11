namespace TPCaisseEnregistreuse.Services
{
    public class UploadService : IUploadService
    {
        private readonly IWebHostEnvironment _env;

        public UploadService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public string Upload(IFormFile file)
        {
            string guid = Guid.NewGuid().ToString();
            string nomfichier = guid + "-" + file.Name;
            string pathServer = Path.Combine(_env.WebRootPath, "images", nomfichier);
            FileStream stream = File.Create(pathServer);
            file.CopyTo(stream);
            stream.Close();

            return "/images/" + nomfichier;
        }
    }
}
