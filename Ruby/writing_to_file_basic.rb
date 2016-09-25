class WritingToFileBasic

  write_handler = File.new("yourSum.txt", "w") # "name of file" , Write

  write_handler.puts("Enter stuff here to be written to file").to_s

  write_handler.close

  data_from_file = File.read("yourSum.txt")

  puts "Data from file : " + data_from_file


end