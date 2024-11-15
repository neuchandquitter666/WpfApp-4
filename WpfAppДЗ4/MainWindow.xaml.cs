using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfAppДЗ4
{
    /*  /// <summary>
      /// Логика взаимодействия для MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {
          public MainWindow()
          {
              InitializeComponent();
              DataContext = new GameViewModel();
          }

          // Реагирование на нажатия клавиш
          protected override void OnKeyDown(KeyEventArgs e)
          {
              base.OnKeyDown(e);
              GameViewModel viewModel = DataContext as GameViewModel;
              switch (e.Key)
              {
                  case Key.Left:
                      viewModel.MoveLeft();
                      break;
                      // Добавьте аналогичные случаи для MoveRight, MoveUp, MoveDown
              }
          }
      }
      public class GameViewModel : INotifyPropertyChanged
      {
          private GameBoard gameBoard;

          public Tile[,] Board => gameBoard.Board;
          public int Score => gameBoard.Score;
          public bool GameOver => gameBoard.GameOver;

          public GameViewModel()
          {
              gameBoard = new GameBoard();
          }

          public void MoveLeft()
          {
              gameBoard.MoveLeft();
              OnPropertyChanged(nameof(Board));
              OnPropertyChanged(nameof(Score));
              OnPropertyChanged(nameof(GameOver));
          }

        

          public event PropertyChangedEventHandler PropertyChanged;
          protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
          {
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
          }
      }
      public class GameBoard
      {
          private const int Size = 4;
          private Tile[,] board;
          private Random random;
          public int Score { get; private set; }
          public bool GameOver { get; private set; } = false;

          public GameBoard()
          {
              board = new Tile[Size, Size];
              random = new Random();
              AddRandomTile();
              AddRandomTile();
          }

          public Tile[,] Board => board;

          public void MoveLeft()
          {
              // Логика перемещения плиток влево
              // Слияние плиток и добавление нового элемента после движения
          }

          // Добавьте аналогичные методы для MoveRight, MoveUp, MoveDown

          private void AddRandomTile()
          {
              // Добавление новой плитки на игровое поле
              // Плитка 2 (90% вероятности) или 4 (10% вероятности)
          }

          private void CheckGameOver()
          {
              // Логика проверки завершения игры
          }
      }*/
 
///

    /// Interaction logic for MainWindow.xaml
///</summary>
public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void Login_Click(object sender, RoutedEventArgs e)
            {
                // Handle login logic
            }

            private void Cancel_Click(object sender, RoutedEventArgs e)
            {
                // Handle cancel logic
            }
        }
    }
