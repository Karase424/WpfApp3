﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private List<string> imagesStore;
        private int currentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            LoadImages(@"C:\Users\Kalina_06\Desktop\image");
            DisplayImage();
        }

        private void LoadImages(string path)
        {
            if (Directory.Exists(path))
            {
                imagesStore = new List<string>(Directory.GetFiles((path), "*.jpg"));
                imagesStore.AddRange(Directory.GetFiles((path), "*.png"));
                imagesStore.AddRange(Directory.GetFiles((path), "*.jfif"));
            }

        }
        private void DisplayImage()
        {
            if (imagesStore == null || imagesStore.Count == 0)
            {
                MessageBox.Show("Папка пуста или нет изображений");
                return;
            }
            var imagePath = imagesStore[currentIndex];
            DisplayImageForm.Source = new BitmapImage(new Uri(imagePath));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Back image
            if (imagesStore == null || imagesStore.Count == 0)
            {
                MessageBox.Show("Тут нет картинок");
                return;
            }
            currentIndex = (currentIndex - 1 + imagesStore.Count) % imagesStore.Count;
            DisplayImage();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            //Next image
            if (imagesStore == null || imagesStore.Count == 0)
            {
                MessageBox.Show("Тут нет картинок");
                return;
            }
            currentIndex = (currentIndex + 1) % imagesStore.Count;
            DisplayImage();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 window = new Window4();
            window.Show();
        }

        private void TreeViewItem_OnSelected(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show(messageBoxText: "Выбран язык программирования: " + treeViewItem.Header.ToString(), caption: "Выбор языка програмирования", MessageBoxButton.OK);
        }
    }
}
