pipeline {
	agent none
	
	environment {
		val1 = 'ola'
		branchname = '$(BRANCH_NAME)'
	}
	
	stages {
		stages('pre') {
			steps {
				println ('NO BRANCH MAIN')		
			}
		}
		stage('checkout') {
			steps {
				println 'branch->$(branchname)'
				agent any
				checkout sm
				when {
					expression {
						$(val1) == 'ola' {
							println 'diferente'
						}
					}	
				}
			}
		}
		stage('build') {
			steps {
				println 'val1->$(val1)'
				println '$(BUILD_ID)->$(JOB_NAME):$(BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			println('Sucesso')
		}
	}
}


