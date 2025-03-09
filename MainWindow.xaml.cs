using System;
using System.Windows;
using System.Windows.Controls;

namespace SiuPlaylist
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Inicia los componentes de la interfaz gráfica
        }

        // Método que se ejecuta cuando hacen click izquierdo en cualquier botón
        private void AbrirVideoConOpciones(object sender, RoutedEventArgs e)
        {
            // Mensajito informando al usuario que debe hacer click derecho para ver más opciones
            MessageBox.Show("Haz click derecho para elegir entre video original o subtitulado.", "Opciones de Video");
        }

        // Evento para la opción "Ver Video Original" 
        private void VerVideoOriginal(object sender, RoutedEventArgs e)
        {
            try
            {
                // Aquí se identifica el botón que disparó el menú
                Button button = (sender as MenuItem)?.Parent is ContextMenu menu ? (menu.PlacementTarget as Button) : null;
                if (button == null) return; // Si no se encuentra el botón, se sale del método

                string videoUrl = "";

                // Determina la URL según el texto del botón
                switch (button.Content.ToString())
                {
                    case "SHE'S NOT AFRAID":
                        videoUrl = "https://www.youtube.com/watch?v=-89ouCz4wm0";
                        break;
                    case "BUSY WOMAN":
                        videoUrl = "https://www.youtube.com/watch?v=3m6NBnqLc-g";
                        break;
                    case "TRAINING SEASON":
                        videoUrl = "https://www.youtube.com/watch?v=ZjBZ8MUnB0E";
                        break;
                    case "FROM THE START":
                        videoUrl = "https://www.youtube.com/watch?v=lSD_L-xic9o";
                        break;
                    case "LOSE MY BREATH":
                        videoUrl = "https://www.youtube.com/watch?v=SQ1yPMTIwCU";
                        break;
                    case "WICKED GAME":
                        videoUrl = "https://www.youtube.com/watch?v=jd-qI62gNJM";
                        break;
                    case "ALL THAT JAZZ":
                        videoUrl = "https://www.youtube.com/watch?v=GVGs2zogkcw&list=LL&index=10";
                        break;
                    case "DONE FOR ME":
                        videoUrl = "https://www.youtube.com/watch?v=TdyllLZeviY";
                        break;
                    case "SLOW DANCING":
                        videoUrl = "https://www.youtube.com/watch?v=eI0iTRS0Ha8";
                        break;
                    default:
                        MessageBox.Show("Video no reconocido.");
                        return;
                }

                // Abre el enlace en el navegador predeterminado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = videoUrl,
                    UseShellExecute = true // Usa el sistema operativo para abrir la URL
                });
            }
            catch (Exception ex)
            {
                // Muestra un mensaje si algo sale mal
                MessageBox.Show($"Error al abrir el video original: {ex.Message}");
            }
        }

        // Método para la opción "Ver Video Subtitulado"
        private void VerVideoSubtitulado(object sender, RoutedEventArgs e)
        {
            try
            {
                // Aquí se identifica el botón que disparó el menú
                Button button = (sender as MenuItem)?.Parent is ContextMenu menu ? (menu.PlacementTarget as Button) : null;
                if (button == null) return; // // Si no se encuentra el botón, se sale del método

                string videoUrl = "";

                // Determina la URL según el texto del botón
                switch (button.Content.ToString())
                {
                    case "SHE'S NOT AFRAID":
                        videoUrl = "https://www.youtube.com/watch?v=Tm_RiaWNiDU";
                        break;
                    case "BUSY WOMAN":
                        videoUrl = "https://www.youtube.com/watch?v=P9MxGvHslPg";
                        break;
                    case "TRAINING SEASON":
                        videoUrl = "https://www.youtube.com/watch?v=clC8XdnUB1A";
                        break;
                    case "FROM THE START":
                        videoUrl = "https://www.youtube.com/watch?v=1DGL5POVae8";
                        break;
                    case "LOSE MY BREATH":
                        videoUrl = "https://www.youtube.com/watch?v=Qlt_9g9zxwk";
                        break;
                    case "WICKED GAME":
                        videoUrl = "https://www.youtube.com/watch?v=oxPpxhcgTt4";
                        break;
                    case "ALL THAT JAZZ":
                        videoUrl = "https://www.youtube.com/watch?v=USxF_VRlmrQ";
                        break;
                    case "DONE FOR ME":
                        videoUrl = "https://www.youtube.com/watch?v=mbgLBtF-RM8";
                        break;
                    case "SLOW DANCING":
                        videoUrl = "https://www.youtube.com/watch?v=dHCyJsOSxDs";
                        break;
                    default:
                        MessageBox.Show("Video no reconocido.");
                        return;
                }

                // Abre el enlace en el navegador predeterminado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = videoUrl,
                    UseShellExecute = true // Usa el sistema operativo para abrir la URL
                });
            }
            catch (Exception ex)
            {
                // Muestra un mensaje si algo sale mal
                MessageBox.Show($"Error al abrir el video subtitulado: {ex.Message}");
            }
        }
    }
}
//Fin<3
