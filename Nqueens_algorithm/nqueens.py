from prettytable import PrettyTable
import time

prettyTable = PrettyTable([])

class Queens(object):

    def __init__(self, number_of_queens):
        self.chessboard = [0] * number_of_queens
        self.number_of_queens = number_of_queens
        self.prettyTable = prettyTable
        self.chess_dict = {}
        self.alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L']
        self.counter = 0

    def can_place_queen(self, row, col):
        ''' This method returns True, if a queen can be placed in a row and col
            otherwise it returns False '''

        for cell_index in range(0, row):
            if ((self.chessboard[cell_index] == col) or 
               ((cell_index - row) == (self.chessboard[cell_index] - col)) or 
               ((cell_index - row) == (col - self.chessboard[cell_index]))):
                   return False
        return True    
    
    def place_queens(self, row, chess_size):
        ''' Using backtracking this method prints all possible placements of N 
            queens on an NxN chessboard so that they are non-attacking '''

        for col in range(0, chess_size):
            if (self.can_place_queen(row, col)):
                self.chessboard[row] = col

                if(row == chess_size - 1):
                    self.print_queens(self.chessboard)
                else:
                    self.place_queens(row + 1, chess_size)
            
    def print_queens(self, chessboard_size):
        chess_size = len(chessboard_size)
        column_index = len(chessboard_size)
        
        for index in range(0, chess_size):
            chess_column = []
            for j in range(0, chess_size):
                if(self.chessboard[index] == j):
                    chess_column.append("Q ")
                else:
                    chess_column.append("* ")
            column_index -= 1
            self.chess_dict[str(column_index)] = chess_column
        
        letter = 0
        for key in range(chess_size-1, -1, -1):
            self.prettyTable.add_column(self.alphabet[letter], self.chess_dict[str(key)]) 
            letter += 1     
        self.counter += 1
        print (self.prettyTable)
        self.prettyTable = PrettyTable()
       

    def call_place_queens(self):
        self.place_queens(0, self.number_of_queens)
        self.possible_solutions()
    
    def possible_solutions(self):
        print ("\nNumber of possible solutions to place %d queens on %dx%d chessboard: %d" % 
              (self.number_of_queens, self.number_of_queens, self.number_of_queens, self.counter))

def main():
    queens = Queens(12)
    start = time.time()
    queens.call_place_queens()
    end = time.time()
    print ("Execution time of the function with %d queens: %.10f seconds\n" 
           % (queens.number_of_queens,(end - start)))

if __name__ == '__main__':
    main()