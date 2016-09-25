puts "how many numbers would you like to check?"
amount = gets.chomp.to_i

list = []
amount.times do
  print "Number: "
  list.push(number = gets.chomp.to_i)

end

list.each do |x|
  if x.even?
    puts 'Yes'
  else
    puts 'No'
  end
end