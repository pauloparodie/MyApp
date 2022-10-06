pipeline {
	agent none
	
	environment {
		val1 = 'ola'
		branchname = '$(env.BRANCH_NAME)'
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
				println 'branch->$(env.branchname)'
				checkout scm
				when {
					expression {
						$(env.val1) == 'ola' {
							println 'diferente'
						}
					}	
				}
				println 'RESULT->$(currentBuild.result)'
				junit '**/target/*.xml'
			}
		}
		stage('build') {
			agent any
			steps {
				println 'val1->$(env.val1)'
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


