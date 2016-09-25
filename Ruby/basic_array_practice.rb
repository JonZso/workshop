class ArrayStuff

  favourite_games = ["Dead Space,", "Last of us", 45, "Battlefield", "Call of duty", 9.1, "Rainbow six"]

  if favourite_games.any? { 'Dead Space' } #Using ".any? function checks the array if Deadspace is in the array"
    puts "Game is found"
  end

  puts favourite_games[-1] # using the minus goes backwards through the array (Dead space will be 0 or -5) (-1 prints last entery)

  puts "#{favourite_games[-1]} is a good game"
  print favourite_games[0..3]

  puts favourite_games.fetch(43, "ID wasn't found, soz")
  puts "Index of last of us : #{favourite_games.index("Last of us")}"

  testingArray = Array.new(4, 'null')
  testingArray[-1] = 'End'
  print testingArray

  empty_table = Array.new(2) { Array.new(3, 'null') } #Quick 2D Array [{'null','null','null},{'null','null','null'}]
  puts #newline
  print(favourite_games.last(2))
  puts

  s = [1, 2, 3] #=> [1, 2, 3]
  t = [4, 5, 6, [7, 8]] #=> [4, 5, 6, [7, 8]]
  a = [s, t, 9, 10] #=> [[1, 2, 3], [4, 5, 6, [7, 8]], 9, 10]
  a.flatten #=> [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  p a = [1, 2, [3, [4, 5]]]
  p a.flatten(1) #=> [1, 2, 3, [4, 5]]


  favourite_games.replace(['x', 'j'])
  p favourite_games
  favourite_games.replace(["Jon", "More Stuff"])
  favourite_games.insert(-1, "omg INSERT")
  p favourite_games.to_s

  a = %w{ a b j c d e f o a n}
  a.keep_if { |v| v =~ /[jon]/ } #=> ["a", "e"]


  messyArray = ["Jon", "Smith", 5454, "Kaylan", "Ken", 34, 343, 11, 434, 2, "Alex"]
  p messyArray
  messyArray.keep_if { |x| x =~ /[abcdefghijklmnopqestuvwxyz]/ }
  p messyArray
  p messyArray.pop
  messyArray.push("Alex")
  messyArray.push("Alex")
  messyArray.push("Alex")
  # p messyArray
  # p messyArray.uniq! #Removes doubles
  # p messyArray
  # p messyArray.uniq! #shows nil if no doubles found
  # p messyArray

  if messyArray.uniq! == nil
    p "no doubles found"
  else
    p 'doubles found'
    p ' sorry'

  end


end