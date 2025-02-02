﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kviz
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string[] valaszok = { "kockás zsiráf", "aligátor", "Róka", "Fehérfejű rétisas", "Kecske" };
		List<Allat> allats = new List<Allat>();

		int db = 1;
		int sum = 0;
		float jó = 0;
		
		public MainWindow()
		{
			InitializeComponent();
			nyitokep.Source = new BitmapImage(new Uri("/img/are-you-ready-vector.jpg", UriKind.Relative));
        }

		private void Btn1_Click(object sender, RoutedEventArgs e)
		{
			btn1.IsEnabled = false;
			sum++;
			img1.Visibility = Visibility.Visible;
            nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
            if (valaszok.Contains(btn1.Content))
			{
				btn1.Background = Brushes.GreenYellow;
				img2.Visibility = Visibility.Hidden;
				img3.Visibility = Visibility.Hidden;
				img4.Visibility = Visibility.Hidden;
				btn1.Visibility = Visibility.Visible;
				btn4.Visibility = Visibility.Hidden;
				btn2.Visibility = Visibility.Hidden;
				btn3.Visibility = Visibility.Hidden;
				jó++;
				nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			}



		}

		private void btn2_Click(object sender, RoutedEventArgs e)
		{
			btn2.IsEnabled = false;
			sum++;
			img2.Visibility = Visibility.Visible;
			nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			if (valaszok.Contains(btn2.Content))
			{
				btn2.Background = Brushes.GreenYellow;
				img1.Visibility = Visibility.Hidden;
				img3.Visibility = Visibility.Hidden;
				img4.Visibility = Visibility.Hidden;
				btn2.Visibility = Visibility.Visible;
				btn1.Visibility = Visibility.Hidden;
				btn4.Visibility = Visibility.Hidden;
				btn3.Visibility = Visibility.Hidden;
				jó++;
				nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			}



		}

		private void btn3_Click(object sender, RoutedEventArgs e)
		{
			btn3.IsEnabled = false;
			sum++;
			img3.Visibility = Visibility.Visible;
			nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			if (valaszok.Contains(btn3.Content))
			{
				btn3.Background = Brushes.GreenYellow;
				img1.Visibility = Visibility.Hidden;
				img2.Visibility = Visibility.Hidden;
				img4.Visibility = Visibility.Hidden;
				btn3.Visibility = Visibility.Visible;
				btn1.Visibility = Visibility.Hidden;
				btn2.Visibility = Visibility.Hidden;
				btn4.Visibility = Visibility.Hidden;
				jó++;
				nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			}



		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{
			btn4.IsEnabled = false;
			sum++;

			img4.Visibility = Visibility.Visible;

			nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			if (valaszok.Contains(btn4.Content))
			{
				btn4.Background = Brushes.GreenYellow;

				img1.Visibility = Visibility.Hidden;
				img2.Visibility = Visibility.Hidden;
				img3.Visibility = Visibility.Hidden;

				btn4.Visibility = Visibility.Visible;
				btn1.Visibility = Visibility.Hidden;
				btn2.Visibility = Visibility.Hidden;
				btn3.Visibility = Visibility.Hidden;

				jó++;
				nyomas.Content = $"Jó tipp:{jó} \nÖsszes tipp: {sum}";
			}



		}

		private void Bezar(object sender, RoutedEventArgs e )
		{
			this.Close();
		}

		private void btn5_Click(object sender, RoutedEventArgs e)
		{
			StreamReader r = new StreamReader("allatok.txt");
			while (!r.EndOfStream)
			{
				string sor = r.ReadLine(); 
				string[] reszek = sor.Split(';'); 
				Allat t = new Allat(reszek[0], reszek[1], reszek[2], reszek[3], reszek[4]);
				allats.Add(t); 
			}
			r.Close();

			nyitokep.Visibility = Visibility.Hidden;
			btn5.Content = "Tovább";

			switch (db)
			{
				case 1:
					btn1.Background = Brushes.LightYellow;
					btn2.Background = Brushes.LightYellow;
					btn3.Background = Brushes.LightYellow;
					btn4.Background = Brushes.LightYellow;

					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;

					lbl1.Content = allats[0].Kerdes;
					btn1.Content = allats[0].V1;
					btn2.Content = allats[0].V2;
					btn3.Content = allats[0].V3;
					btn4.Content = allats[0].V4;

					img1.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img2.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img3.Source = new BitmapImage(new Uri("/img/ok.png", UriKind.Relative));
					img4.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					allatok_kep.Source = new BitmapImage(new Uri("/img/zsiraf.jpg", UriKind.Relative));

					db++;
					break; 
				case 2:
					btn1.IsEnabled = true;
					btn2.IsEnabled = true;
					btn3.IsEnabled = true;
					btn4.IsEnabled = true;

					btn1.Background = Brushes.LightYellow;
					btn2.Background = Brushes.LightYellow;
					btn3.Background = Brushes.LightYellow;
					btn4.Background = Brushes.LightYellow;

					btn1.Visibility = Visibility.Visible;
					btn2.Visibility = Visibility.Visible;
					btn3.Visibility = Visibility.Visible;
					btn4.Visibility = Visibility.Visible;

					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;

					lbl1.Content = allats[1].Kerdes;
					btn1.Content = allats[1].V1;
					btn2.Content = allats[1].V2;
					btn3.Content = allats[1].V3;
					btn4.Content = allats[1].V4;

					img1.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img2.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img3.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img4.Source = new BitmapImage(new Uri("/img/ok.png", UriKind.Relative));
					allatok_kep.Source = new BitmapImage(new Uri("/img/aligator.jpg", UriKind.Relative));
					db++;
					break;
				case 3:
					btn1.IsEnabled = true;
					btn2.IsEnabled = true;
					btn3.IsEnabled = true;
					btn4.IsEnabled = true;

					btn1.Background = Brushes.LightYellow;
					btn2.Background = Brushes.LightYellow;
					btn3.Background = Brushes.LightYellow;
					btn4.Background = Brushes.LightYellow;

					btn1.Visibility = Visibility.Visible;
					btn2.Visibility = Visibility.Visible;
					btn3.Visibility = Visibility.Visible;
					btn4.Visibility = Visibility.Visible;

					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;

					lbl1.Content = allats[2].Kerdes;
					btn1.Content = allats[2].V1;
					btn2.Content = allats[2].V2;
					btn3.Content = allats[2].V3;
					btn4.Content = allats[2].V4;

					img1.Source = new BitmapImage(new Uri("/img/ok.png", UriKind.Relative));
					img2.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img3.Source = new BitmapImage(new Uri("/img/X.png", UriKind.Relative));
					img4.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					allatok_kep.Source = new BitmapImage(new Uri("/img/roka.jpg", UriKind.Relative));
					db++;
					break;
				case 4:

					btn1.IsEnabled = true;
					btn2.IsEnabled = true;
					btn3.IsEnabled = true;
					btn4.IsEnabled = true;

					btn1.Background = Brushes.LightYellow;
					btn2.Background = Brushes.LightYellow;
					btn3.Background = Brushes.LightYellow;
					btn4.Background = Brushes.LightYellow;

					btn1.Visibility = Visibility.Visible;
					btn2.Visibility = Visibility.Visible;
					btn3.Visibility = Visibility.Visible;
					btn4.Visibility = Visibility.Visible;

					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;

					lbl1.Content = allats[3].Kerdes;
					btn1.Content = allats[3].V1;
					btn2.Content = allats[3].V2;
					btn3.Content = allats[3].V3;
					btn4.Content = allats[3].V4;

					img1.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img2.Source = new BitmapImage(new Uri("/img/ok.png", UriKind.Relative));
					img3.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img4.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					allatok_kep.Source = new BitmapImage(new Uri("/img/sas.jpg", UriKind.Relative));
					db++;
					break;
				case 5:
					btn1.IsEnabled = true;
					btn2.IsEnabled = true;
					btn3.IsEnabled = true;
					btn4.IsEnabled = true;

					btn1.Background = Brushes.LightYellow;
					btn2.Background = Brushes.LightYellow;
					btn3.Background = Brushes.LightYellow;
					btn4.Background = Brushes.LightYellow;

					btn1.Visibility = Visibility.Visible;
					btn2.Visibility = Visibility.Visible;
					btn3.Visibility = Visibility.Visible;
					btn4.Visibility = Visibility.Visible;

					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;

					lbl1.Content = allats[4].Kerdes;
					btn1.Content = allats[4].V1;
					btn2.Content = allats[4].V2;
					btn3.Content = allats[4].V3;
					btn4.Content = allats[4].V4;

					img1.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img2.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					img3.Source = new BitmapImage(new Uri("/img/ok.png", UriKind.Relative));
					img4.Source = new BitmapImage(new Uri("/img/x.png", UriKind.Relative));
					allatok_kep.Source = new BitmapImage(new Uri("/img/kecske.jpg", UriKind.Relative));
					db++;
					break;
				case 6:

					zarokep.Source = new BitmapImage(new Uri("/img/shocked-surprised.gif", UriKind.Relative));
					lbl1.Content = "Köszönjük hogy játszottál!";
					btn5.Content = "Bezár!";
					btn1.Visibility = Visibility.Hidden;
					btn2.Visibility = Visibility.Hidden;
					btn3.Visibility = Visibility.Hidden;
					btn4.Visibility = Visibility.Hidden;
					allatok_kep.Visibility = Visibility.Hidden;
					img1.Visibility = Visibility.Hidden;
					img2.Visibility = Visibility.Hidden;
					img3.Visibility = Visibility.Hidden;
					img4.Visibility = Visibility.Hidden;
					nyomas.Content = "";
					Label txtb = new Label();
					btn5.Background = Brushes.Red;
					txtb.Height = 200;
					txtb.Width = 450;
					txtb.Margin = new Thickness(250,100,0,0);
					txtb.FontSize = 30;
					txtb.Foreground = new SolidColorBrush(Colors.Black);
					canvas.Children.Add(txtb);
					txtb.Content = $"Eredmény:\nJó tipp: {jó}  Összes tipp: {sum}\nSzázalékban: {Math.Round(jó/sum,2)*100}%";
					db++;

					break;
				case 7:
					Application.Current.Shutdown();
					break;
			}

		}
	}
}
