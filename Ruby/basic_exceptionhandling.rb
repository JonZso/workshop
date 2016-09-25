age = 12
x = 53
name = 'k'
tryAttempts = 3

def myTest(x)
  x = 74
  puts "my test #{x}"
end

myTest(x)


def check_age(age)
  raise ArgumentError, "Enter a positive number" unless age > 0
end

begin
  check_age(-1)
rescue ArgumentError
  puts "Impossible age"
end

begin
  age / name

rescue
  puts "invalid"
  tryAttempts -= 1
  retry unless (tryAttempts.zero?)
  puts 'All Attempts'
end



