pipeline {
	agent none
	
	environment {
		val1 = 'ola'
		branchname = '$(BRANCH_NAME)'
	}
	
	stages {
		stage('pre') {
			agent any
			steps {
				println ('NO BRANCH MAIN')		
			}
		}
		stage('checkout') {
			agent any
			steps {
				println 'branch->$(branchname)'
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
			agent any
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


