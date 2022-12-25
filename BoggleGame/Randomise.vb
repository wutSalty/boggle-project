Module Randomise

    Private rnd As New Random() 'Initialise new random
    Public RegLineCount As Integer = Nothing 'For debugging, shows how many lines there are
    Public SpcLineCount As Integer = Nothing 'Same as Reg line count
    Public RegWordList As New List(Of String) 'Original list of words. Generated at Load
    Public SpcWordList As New List(Of String) 'User word list of words. For custom games
    Public RandomWordList As New List(Of String) 'Randomised list of words. Generated after user chooses a difficulty.

    Public Sub SetUpWordList() 'This is the normal word list. That is, used for all the standard difficulties.
        Dim content As String = My.Resources.english 'Gets file path to direct to txt file
        RegWordList = content.Split(New String() {Convert.ToChar(13), Convert.ToChar(10)}, StringSplitOptions.RemoveEmptyEntries).ToList 'Adds lines of text from file into list

        'Counts how many items in the list
        RegLineCount = RegWordList.Count

        UserWordList() 'Moves onto the custom word list at the same time
        DebugForm.UpdateDebug()

    End Sub

    Public Sub UserWordList() 'This is the special word list. That is, used for custom games.
        'Gets wordlist from the created file
        Using Reader As New StreamReader("Assets\WordList.txt")
            While Reader.EndOfStream = False
                SpcWordList.Add(Reader.ReadLine())

            End While

        End Using

        SpcLineCount = SpcWordList.Count
        DebugForm.UpdateDebug()

    End Sub

    Public Function Shuffle(items As String()) 'Set variables: items = The things in the array
        Dim j As Integer
        Dim temp As String

        For n As Integer = items.Length - 1 To 0 Step -1 'For all the items in the array
            j = rnd.Next(0, n + 1) 'Choose a random number

            'Swaps the words around
            temp = items(n) 'Set current item to temp
            items(n) = items(j) 'Replace current item with new item chosen by random
            items(j) = temp 'Replace new item with old item
        Next n
        Return items.ToList

    End Function

End Module
