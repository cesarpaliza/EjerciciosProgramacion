puts "Imprimir una lista con los primeros 100 números naturales sujeto a las siguientes reglas:"
puts "Cuando el número a imprimir sea 3 o multiplo de 3, reemplazarlo por la palabra 'bizz'"
puts "Cuando el número a imprimir sea 5 o multiplo de 5, reemplazarlo por la palabra 'buzz'"
puts "Cuando el número a imprimir sea multiplo de 3 y de 5, reemplazaro por la palabra 'bizzbuzz'"

def tres? x
  x % 3 == 0
end

def cinco? x
    x % 5 == 0
end

def calculo x
  if tres? x
    print "bizz"
  end
  if cinco? x
    print "buzz"
  elsif !tres? x  
    print x
  end
  puts ""
end

(1..100).each { |a| print calculo a }