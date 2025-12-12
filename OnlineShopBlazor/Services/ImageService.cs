using Microsoft.AspNetCore.Components.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace OnlineShopBlazor.Services
{
    public class ImageService
    {
        private readonly IWebHostEnvironment _environment;

        public ImageService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task SaveImageAsync(IBrowserFile file, string destinationPath, int maxWidth = 800, int maxHeight = 600)
        {
            try
            {
                using var image = await Image.LoadAsync(
                    file.OpenReadStream(maxAllowedSize: 1024 * 1024 * 30) // 30MB limit
                );

                image.Mutate(x =>
                    x.Resize(
                        new ResizeOptions
                        {
                            Size = new Size(maxWidth, maxHeight),
                            Mode = ResizeMode.Max,
                        }
                    )
                );

                await image.SaveAsWebpAsync(destinationPath);
            }
            catch (Exception ex)
            {
                // Fallback: if resizing fails (e.g. unknown format), try saving as is, or rethrow
                // For now, let's rethrow to handle it in the UI
                throw new Exception($"Failed to process image: {ex.Message}");
            }
        }
    }
}
